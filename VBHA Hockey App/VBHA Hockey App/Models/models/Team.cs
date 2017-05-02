using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VBHA_Hockey_App.Models.viewmodels;

namespace VBHA_Hockey_App.Models
{
    public partial class team
    {
        //get all teams that aren't deleted
        public static List<team> GetAll()
        {
            return Global.Repository.All_Teams().ToList();
        }

        //method to get a team by ID
        public static team GetByID(int id)
        {
            return Global.Repository.All_Teams().Where(x => x.ID == id).FirstOrDefault();
        }

        //create a team using NewTeamViewModel
        public static team Create(NewTeamViewModel viewModel)
        {
            team newTeam = new team();
            newTeam.Name = viewModel.TeamName;
            newTeam.Added = DateTime.Now;

            return Global.Repository.Create<team>(newTeam);
        }

        //update a team using NewTeamViewModel
        public team Update(NewTeamViewModel viewModel)
        {
            this.Name = viewModel.TeamName;

            return Global.Repository.Update<team>(this);
        }

        //set the deleted field to the current time.  Team won't appear but is still in database
        public void Delete()
        {
            this.Deleted = DateTime.Now;
            Global.Repository.Update<team>(this);
        }
    }
}
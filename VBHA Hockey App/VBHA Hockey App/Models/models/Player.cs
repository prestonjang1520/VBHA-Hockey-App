using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VBHA_Hockey_App.Models.viewmodels;

namespace VBHA_Hockey_App.Models
{
    public partial class  player
    {
        public static List<player> GetAll()
        {
            return Global.Repository.All_Players().ToList();
        }

        public static List<player> GetAllByTeam(int teamID)
        {
            return Global.Repository.All_Players().Where(x=>x.Speed == teamID).ToList();
        }

        public static player GetByID(int id)
        {
            return Global.Repository.All_Players().Where(x => x.ID == id).FirstOrDefault();
        }

        public static player Create(NewPlayerViewModel viewModel)
        {
            player newPlayer = new player();
            newPlayer.Added = DateTime.Now;
            newPlayer.Attendance = viewModel.Attendance;
            newPlayer.Birthday = viewModel.Birthday;
            newPlayer.Dexterity = viewModel.Dexterity;
            newPlayer.FirstName = viewModel.FirstName;
            newPlayer.HockeyIQ = viewModel.HockeyIQ;
            newPlayer.LastName = viewModel.LastName;
            newPlayer.Position = viewModel.Position;
            newPlayer.Shot = viewModel.Shot;
            newPlayer.Speed = viewModel.Speed;
            newPlayer.Tenacity = viewModel.Tenacity;
            newPlayer.TeamID = viewModel.TeamID;

            return Global.Repository.Create<player>(newPlayer);
        }

        public void Delete()
        {
            this.Deleted = DateTime.Now;
            Global.Repository.Update<player>(this);
        }

        public player Update(NewPlayerViewModel viewModel)
        {
            this.Attendance = viewModel.Attendance;
            this.Birthday = viewModel.Birthday;
            this.Dexterity = viewModel.Dexterity;
            this.FirstName = viewModel.FirstName;
            this.HockeyIQ = viewModel.HockeyIQ;
            this.LastName = viewModel.LastName;
            this.Position = viewModel.Position;
            this.Shot = viewModel.Shot;
            this.Speed = viewModel.Speed;
            this.Tenacity = viewModel.Tenacity;
            this.TeamID = viewModel.TeamID;

            return Global.Repository.Create<player>(this);
        }
    }
}
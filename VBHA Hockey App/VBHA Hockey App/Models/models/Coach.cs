using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VBHA_Hockey_App.Models.viewmodels;

namespace VBHA_Hockey_App.Models
{
    public partial class coach
    {

        public static List<coach> GetAll()
        {
            return Global.Repository.All_Coaches().ToList();
        }

        public static coach Create(NewCoachViewModel viewModel)
        {
            coach newCoach = new coach();
            newCoach.Added = DateTime.Now;
            newCoach.Email = viewModel.Email;
            newCoach.FirstName = viewModel.FirstName;
            newCoach.LastName = viewModel.LastName;
            newCoach.TeamID = viewModel.SelectedTeam;
            newCoach.Password = Hashing.HashPassword(viewModel.Password);

            return Global.Repository.Create<coach>(newCoach);
        }
    }
}
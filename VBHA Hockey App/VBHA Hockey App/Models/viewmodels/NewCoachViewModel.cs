using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VBHA_Hockey_App.Models.viewmodels
{
    public class NewCoachViewModel
    {
        [Required(ErrorMessage = "A First Name is required!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "A Last Name is required!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "A Email is required!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        
        public int SelectedTeam { get; set; }

        public string TeamName { get; set; }

        [Required(ErrorMessage = "A Password is required!")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        public List<SelectListItem> Teams { get {
                List<SelectListItem> teams = new List<SelectListItem>();
                teams.Add(new SelectListItem
                {
                    Value = "0",
                    Text = ""
                });

                foreach(var t in team.GetAll())
                {
                    teams.Add(new SelectListItem
                    {
                        Value = t.ID.ToString(),
                        Text = t.Name
                    });
                }

                return teams;
            }
        }
    }
}
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
        public string Email { get; set; }

        [Required(ErrorMessage = "A Team is required!")]
        public int SelectedTeam { get; set; }

        [Required(ErrorMessage = "A Password is required!")]
        public string Password { get; set; }

        public List<SelectListItem> Teams { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VBHA_Hockey_App.Models.viewmodels
{
    public class NewTeamViewModel
    {
        [Required(ErrorMessage = "A Team Name is required!")]
        public string TeamName { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VBHA_Hockey_App.Models.viewmodels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "User name cannot be blank!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password cannot be blank!")]
        public string Password { get; set; }
    }
}
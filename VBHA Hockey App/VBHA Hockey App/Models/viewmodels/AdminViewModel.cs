using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VBHA_Hockey_App.Models.viewmodels
{
    public class AdminViewModel
    {
        public CoachesViewModel CoachesList { get; set; }

        public TeamsViewModel TeamsList { get; set; }
    }
}
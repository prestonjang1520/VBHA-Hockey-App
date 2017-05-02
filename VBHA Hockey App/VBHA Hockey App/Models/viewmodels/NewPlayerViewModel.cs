using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VBHA_Hockey_App.Models.viewmodels
{
    public class NewPlayerViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }

        public int Speed { get; set; }

        public int Shot { get; set; }

        public int Dexterity { get; set; }

        public int Tenacity { get; set; }

        public int HockeyIQ { get; set; }

        public int Attendance { get; set; }

        public string Birthday { get; set; }

        public int TeamID { get; set; }
    }
}
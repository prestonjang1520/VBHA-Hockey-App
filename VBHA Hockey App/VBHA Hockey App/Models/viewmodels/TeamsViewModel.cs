using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VBHA_Hockey_App.Models.viewmodels
{
    public class TeamsViewModel
    {
        public List<team> Teams { get
            {
                return team.GetAll();
            }
        }
    }
}
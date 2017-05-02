using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VBHA_Hockey_App.Models.viewmodels
{
    public class CoachesViewModel
    {
        public List<coach> Coaches { get
            {
                return coach.GetAll();
            }
        }
    }
}
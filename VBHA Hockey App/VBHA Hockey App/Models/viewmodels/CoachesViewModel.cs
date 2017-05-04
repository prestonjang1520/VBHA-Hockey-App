using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VBHA_Hockey_App.Models.viewmodels
{
    public class CoachesViewModel
    {
        public List<NewCoachViewModel> Coaches { get
            {
                List<NewCoachViewModel> coaches = new List<NewCoachViewModel>();
                foreach(var c in coach.GetAll())
                {
                    coaches.Add(c.GenerateViewModel());
                }

                return coaches;
            }
        }
    }
}
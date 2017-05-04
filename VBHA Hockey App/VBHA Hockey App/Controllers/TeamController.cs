using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VBHA_Hockey_App.Models;

namespace VBHA_Hockey_App.Controllers
{
    [Authorize]
    public class TeamController : Controller
    {
        public ActionResult Index()
        {
            return View();
        } 

        public ActionResult Delete(int teamID)
        {
            team deletedTeam = team.GetByID(teamID);
            if (deletedTeam != null)
                deletedTeam.Delete();

            return RedirectToAction("Index");
        }
    }
}
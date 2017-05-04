using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VBHA_Hockey_App.Models;
using VBHA_Hockey_App.Models.viewmodels;

namespace VBHA_Hockey_App.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            AdminViewModel viewModel = new AdminViewModel();
            viewModel.CoachesList = new CoachesViewModel();
            viewModel.TeamsList = new TeamsViewModel();
            
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult AddCoach()
        {
            NewCoachViewModel ncvm = new NewCoachViewModel();
            return View(ncvm);
        }

        [HttpPost]
        public ActionResult AddCoach(NewCoachViewModel data)
        {
            if (ModelState.IsValid)
            {
                coach.Create(data);
                return RedirectToAction("Index");
            }

            return View(data);
        }

        [HttpGet]
        public ActionResult AddTeam()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTeam(NewTeamViewModel data)
        {
            if (ModelState.IsValid)
            {
                team.Create(data);
                return RedirectToAction("Index");
            }

            return View(data);
        }
    }
}
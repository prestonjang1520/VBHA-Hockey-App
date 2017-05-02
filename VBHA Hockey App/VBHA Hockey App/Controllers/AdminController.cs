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
    }
}
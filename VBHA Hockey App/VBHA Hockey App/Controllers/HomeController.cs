using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VBHA_Hockey_App.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Header()
        {
            if (Request.Cookies["admin"] != null)
            {
                ViewBag.Person = "Admin";
            }else if (Request.Cookies["coach"] != null)
            {
                ViewBag.Person = "Coach";
            }

            return PartialView();
        }
    }
}
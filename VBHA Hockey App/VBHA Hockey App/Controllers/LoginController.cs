using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using VBHA_Hockey_App.Models.viewmodels;

namespace VBHA_Hockey_App.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult Index(LoginViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (viewModel.Username == "admin" && viewModel.Password == "pass")
                {
                    HttpCookie cookie = new HttpCookie("admin");
                    Response.Cookies.Add(cookie);
                    FormsAuthentication.SetAuthCookie("admin", false);

                    return RedirectToAction("Index", "Admin");
                }
                else if (viewModel.Username == "coach" && viewModel.Password == "pass")
                {
                    HttpCookie cookie = new HttpCookie("coach");
                    Response.Cookies.Add(cookie);
                    FormsAuthentication.SetAuthCookie("coach", false);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Error = "Username and/or password is invalid.";
                    return View(viewModel);
                }
                
            }

            return View(viewModel);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return View("Index");
        }
    }
}
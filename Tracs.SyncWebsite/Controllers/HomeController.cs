using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tracs.SyncWebsite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sync Module of Tracs System";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can contact Tracs team through email kazkasolutions@gmail.com ";

            return View();
        }
    }
}

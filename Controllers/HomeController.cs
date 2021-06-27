using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PwI_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Strona opisowa.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Strona konktaktowa.";

            return View();
        }
    }
}
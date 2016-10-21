using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaudaMaster.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult NotFound()
        {
            

            return View();
        }

        public ActionResult PageError()
        {
          

            return View();
        }
    }
}

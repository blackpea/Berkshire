using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace html5up_dopetrope_mvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Title = "Dopetrope by HTML5 UP";
            return View();
        }

        public ActionResult LeftSidebar()
        {
            ViewBag.Title = "Left Sidebar - Dopetrope by HTML5 UP";
            return View();
        }

        public ActionResult NoSidebar()
        {
            ViewBag.Title = "No Sidebar - Dopetrope by HTML5 UP";
            return View();
        }

        public ActionResult RightSidebar()
        {
            ViewBag.Title = "Right Sidebar - Dopetrope by HTML5 UP";
            return View();
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}

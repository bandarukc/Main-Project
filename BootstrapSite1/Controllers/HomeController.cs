using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapSite1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title="Home";
            return View();
        }

        public ActionResult Profile()
        {
            
            return View();
        }
        public ActionResult Posts()
        {
            
            return View();
        }
        public ActionResult History()
        {
            
            return View();
        }
        

    }
}
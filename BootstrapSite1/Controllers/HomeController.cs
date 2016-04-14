using BootstrapSite1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapSite1.Controllers
{
    public class HomeController : Controller
    {
       
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

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Help()
        {

            return View();
        }
    }
}
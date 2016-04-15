using BootstrapSite1.Domain.Abstract;
using BootstrapSite1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BootstrapSite1.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
       
        IAuthentication authentication;
        
        public AccountController(IAuthentication authentication)
        {
            this.authentication = authentication;
        }
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            
            
            if (ModelState.IsValid)
            {
                int result=authentication.Authenticate(model.UserName, model.Password);
                if (result==1)

                {
                    Session["LogedInUser"] = model.UserName;
                    
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
                }
                else if (result==2)
                {
                    Session["LogedInUser"] = model.UserName;
                    
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return Redirect(returnUrl ?? Url.Action("List", "Product"));
                }

                else
                {
                    ModelState.AddModelError("", "Incorrect username or password");
                    return View();
                }
            }
            else
            {
                return View();
            }

        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Admin");
        }

    

    }
}
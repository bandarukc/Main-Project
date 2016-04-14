using BootstrapSite1.Domain.Abstract;
using BootstrapSite1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BootstrapSite1.Controllers
{
    [Authorize]
    public class CommunityController : Controller
    {
        private readonly ICommunityRepository repository;
        public int PageSize = 9;
        public CommunityController(ICommunityRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(int page = 1)
        {
            CommunityListViewModel model = new CommunityListViewModel
            {
                Communities = repository.Communities
                
                .OrderBy(p => p.ResidentId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Communities.Count()
                },
                

            };
            return View(model);
        }

        public ActionResult Profile()
        {
            var U_Name = Session["LogedInUser"].ToString();
            CommunityListViewModel model = new CommunityListViewModel
            {
                Communities = repository.Communities
                .Where(p=>p.Email==U_Name)
                     
            };
            return View(model);
        }
     
        
    }
}
﻿using BootstrapSite1.Domain.Abstract;
using BootstrapSite1.Domain.Entities;
using BootstrapSite1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapSite1.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductRepository repository;
        public int PageSize = 3;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string category, int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                                repository.Products.Count() :
                                repository.Products.Where(p => p.Category == category).Count()
                },
                CurrentCategory = category
                
            };
            return View(model);
        }

        public ViewResult List_Automobiles(int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                .Where(p => p.Category == "Automobile")
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Where(p => p.Category == "Automobile").Count()
                },
                CurrentCategory = "Automobile"

            };
            return View(model);
        }

        public ViewResult List_Furniture(int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                .Where(p => p.Category == "Furniture")
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Where(p => p.Category == "Furniture").Count()
                },
                CurrentCategory = "Furniture"

            };
            return View(model);
        }

        public ViewResult List_Other(int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                .Where(p => p.Category == "Other")
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Where(p => p.Category == "Other").Count()
                },
                CurrentCategory = "Other"

            };
            return View(model);
        }

        public ViewResult List_Mobile(int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                .Where(p => p.Category == "Mobile")
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Where(p => p.Category == "Mobile").Count()
                },
                CurrentCategory = "Mobile"

            };
            return View(model);
        }

        public ViewResult List_Laptop(int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                .Where(p => p.Category == "Laptop")
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Where(p => p.Category == "Laptop").Count()
                },
                CurrentCategory = "Laptop"

            };
            return View(model);
        }

        public ViewResult List_Other_Electronics(int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = repository.Products
                .Where(p => p.Category == "OtherElectronics")
                .OrderBy(p => p.ProductId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Where(p => p.Category == "OtherElectronics").Count()
                },
                CurrentCategory = "OtherElectronics"

            };
            return View(model);
        }

        public ActionResult MyPosts()
        {
            var U_name = Session["LogedInUser"].ToString();
            return View(repository.Products.Where(p=>p.Email==U_name));
        }

        public ViewResult MyPostEdit(int productId)
        {
            Product product = repository.Products.FirstOrDefault(p => p.ProductId == productId);
            return View(product);
        }
        [HttpPost]
        public ActionResult MyPostEdit(Product product)
        {
            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = string.Format("{0} has been saved",
                    product.Name);
                return RedirectToAction("MyPosts");

            }
            else
            {
                return View(product);
            }
        }
        [HttpPost]
        public ActionResult Delete(int productId)
        {
            Product deletedProduct = repository.DeleteProduct(productId);
            if (deletedProduct != null)
            {
                TempData["message"] = string.Format("{0} was deleted",
                   deletedProduct.Name);
            }
            return RedirectToAction("Myposts");
        }

        public ViewResult PostAd()
        {
            return View(new Product());
        }
        [HttpPost]
        public ActionResult PostAd(Product product)
        {

            if (ModelState.IsValid)
            {
                repository.SaveProduct(product);
                return RedirectToAction("List");

            }
            else
            {
                return View(product);
            }
        }

          
    }
}
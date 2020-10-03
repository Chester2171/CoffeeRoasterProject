﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NightSightsCoffee.Models;
using NightSightsCoffee.Models.ViewModels;

namespace NightSightsCoffee.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 16;
        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index(string category, int productPage = 1)
        => View(new ProductsListViewModel
        {
            Products = repository.Products
                .Where(p => category == null || p.Category == category)
                .OrderBy(p => p.ProductID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = category == null ?
                    repository.Products.Count() :
                    repository.Products.Where(e =>
                        e.Category == category).Count()
            },
            CurrentCategory = category
        });

        [HttpGet("Contact")]
        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpGet("Story")]
        public IActionResult OurStory()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}

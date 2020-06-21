using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HouseBack.Models;
using HouseBack.DAL;
using HouseBack.ViewModels;

namespace HouseBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly HouseDbContext _context;
        public HomeController(HouseDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM home = new HomeVM
            {
                HomeBanner = _context.HomeBanner.FirstOrDefault(),
                WhatWeDoHome = _context.WhatWeDoHomePage.FirstOrDefault(),
                Projects = _context.Projects.OrderByDescending(p => p.AddedDate).Take(3),
                Awards = _context.Awards.OrderByDescending(a => a.Year),
            };
            ViewBag.Projects = _context.Projects.Count();
            ViewBag.Age = DateTime.Now.Year - 2000;
            ViewBag.Staff = 24;
            return View(home);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseBack.DAL;
using Microsoft.AspNetCore.Mvc;

namespace HouseBack.Controllers
{
    public class WhatWeDoController : Controller
    {
        private readonly HouseDbContext _context;
        public WhatWeDoController(HouseDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.WhatWeDos);
        }
    }
}
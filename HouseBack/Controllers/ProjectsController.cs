using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseBack.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HouseBack.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly HouseDbContext _context;
        public ProjectsController(HouseDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.ProjectsCount = _context.Projects.Count();
            return View(_context.Projects.Take(2));
        }
        public IActionResult SingleProject(int? id)
        {
            if (id == null || !_context.Projects.Any(p => p.Id == id))
            {
                return PartialView("ErrorPV");
            }
            return View(_context.Projects.Where(p => p.Id == id).Include(p => p.ProjectDetailImages).FirstOrDefault());
        }
    }
}
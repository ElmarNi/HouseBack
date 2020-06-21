using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseBack.DAL;
using Microsoft.AspNetCore.Mvc;

namespace HouseBack.Controllers
{
    public class AjaxController : Controller
    {
        private readonly HouseDbContext _context;
        public AjaxController(HouseDbContext context)
        {
            _context = context;
        }
        public IActionResult LoadProjects(int skip)
        {
            var model = _context.Projects.OrderByDescending(p => p.AddedDate).Skip(skip).Take(2);
            ViewBag.ProjectsCount = _context.Projects.Count() - skip;
            if ((_context.Projects.Count() - skip) == 1)
            {
                var lastPro = _context.Projects.OrderByDescending(p => p.AddedDate).LastOrDefault();
                return PartialView("_LoadProjectsPV", model);
            }
            return PartialView("_LoadProjectsPV", model);
        }
    }
}
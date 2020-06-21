using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseBack.DAL;
using HouseBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace HouseBack.Controllers
{
    public class ContactController : Controller
    {
        private readonly HouseDbContext _context;
        public ContactController(HouseDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Contact contact)
        {
            if (!ModelState.IsValid)
            {
                return View(contact);
            }
            await _context.Contacts.AddAsync(contact);
            await _context.SaveChangesAsync();
            return PartialView("ContactSuccessPV");
        }
    }
}
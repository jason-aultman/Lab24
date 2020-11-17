using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab24.Context;
using Lab24.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lab24.Controllers
{
    public class CheckOutController : Controller
    {
        public readonly MovieDbContext _context;
        public readonly UserManager<IdentityUser> _userManager;
        public CheckOutController(MovieDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CheckOut(int Id)
        {
            var user = _userManager.GetUserAsync(HttpContext.User).GetAwaiter().GetResult();
            _context.CheckedOutMovies.Add(new CheckedOutMovies() { MovieId = Id, UserId = user.Id, DueDate = DateTime.Now.AddDays(7) });
            _context.SaveChanges();
            
            return View();
        }
       
    }
}
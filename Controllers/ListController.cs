using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

using Lab24.Context;
using Lab24.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Lab24.Controllers
{
    public class ListController : Controller
    {
        private readonly MovieDbContext _context;
        public ListController(MovieDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allMovies = from m in _context.Movies
                            select m;
            return View(allMovies.ToList());
        }
        [Authorize]
        public IActionResult CheckOut(int id)
        {

                var movieToCheckout = (from m in _context.Movies
                                       where (m.Id == (id+1))
                                       select m).FirstOrDefault();
                return View(movieToCheckout);
        }
        public IActionResult ReturnToList()
        {
            return View("Index");
        }
    }
}
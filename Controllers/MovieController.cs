using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Lab24.Context;
using Lab24.Models;
using Lab24.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lab24.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieDbContext _context;
        private readonly IAddable _addToDB;
        
        public MovieController(MovieDbContext movieDBcontext, IAddable addable):base()
        {
            _context = movieDBcontext;
            _addToDB = addable;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register(MovieModel movieModel)
        {
            _addToDB.Store(movieModel, _context);
            var result = new ResultModel() { Title = movieModel.Title };
            return View("Result", result);
        }
    }
}
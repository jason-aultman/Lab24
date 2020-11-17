using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab24.Context;
using Lab24.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab24.Controllers
{
    public class SearchController : Controller
    {
        private readonly MovieDbContext _movieDBContext;

        public SearchController(MovieDbContext movieDBContext)
        {
            _movieDBContext = movieDBContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SearchResultTitle(SearchModel searchModel)
        {
            var result = (from m in _movieDBContext.Movies
                          where m.Title.Contains(searchModel.Title)
                         select m).ToList();
            var model = new SearchResultTitle();
            model.MovieResults = result;
            return View(model);
        }
        public IActionResult SearchResultGenre(SearchModel searchModel)
        {
            var result = (from m in _movieDBContext.Movies
                          where m.Genre==searchModel.genres.ToString()
                          select m).ToList();
            var model = new SearchResultGenre();
            model.MovieResults = result;
            return View(model);
        }
    }
}
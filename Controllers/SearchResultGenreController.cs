using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab24.Controllers
{
    public class SearchResultGenreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
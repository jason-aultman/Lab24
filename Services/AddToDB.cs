using Lab24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab24.Context;


namespace Lab24.Services
{
    public class AddToDB : IAddable
    {
        public void Store(MovieModel movieModel, MovieDbContext _context)
        {
            var newMovie = new Movies();
            newMovie.Title = movieModel.Title;
            newMovie.Genre = movieModel.Genre.ToString();
            _context.Movies.Add(newMovie);
            _context.SaveChanges();
        }
    }
}

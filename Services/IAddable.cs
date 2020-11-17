using Lab24.Context;
using Lab24.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab24.Services
{
    public interface IAddable
    {
        public void Store(MovieModel m, MovieDbContext context);
    }
}

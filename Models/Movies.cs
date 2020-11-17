using System;
using System.Collections.Generic;

namespace Lab24.Models
{
    public partial class Movies
    {
        public Movies()
        {
            CheckedOutMovies = new HashSet<CheckedOutMovies>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public decimal? Runtime { get; set; }

        public virtual ICollection<CheckedOutMovies> CheckedOutMovies { get; set; }
    }
}

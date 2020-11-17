using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Lab24.Models
{
    public class MovieModel
    {
      
        
        [Required(ErrorMessage = "{0} is required")]
        public int ID { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        public string Title { get; set; }

        public Genres Genre { get; set; }
        
        public DateTime Year { get; set; }
        public string Actors { get; set; }
       
        public string Directors { get; set; }
    }
}

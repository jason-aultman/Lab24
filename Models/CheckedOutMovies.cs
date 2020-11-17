using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
namespace Lab24.Models
{
    public partial class CheckedOutMovies
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int? MovieId { get; set; }
        public DateTime? DueDate { get; set; }

        public virtual Movies Movie { get; set; }
        public virtual IdentityUser User { get; set; }
    }
}

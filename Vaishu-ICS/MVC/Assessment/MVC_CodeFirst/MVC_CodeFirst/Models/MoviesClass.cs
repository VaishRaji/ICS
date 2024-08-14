using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CodeFirst.Models
{
    public class MoviesClass
    {
        public DbSet<Movie> Movies { get; set; }

        public ApplicationDbContext() : base("MoviesDB")
        {
        }
    }
}
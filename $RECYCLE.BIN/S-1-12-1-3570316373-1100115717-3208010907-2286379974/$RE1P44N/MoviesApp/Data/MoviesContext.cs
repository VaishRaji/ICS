using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesApp.Data
{
    public class MoviesContext:DbContext

    {
        public DbSet<Movie> Movies { get; set; }
        public MoviesContext(DbContextOptions<MoviesContext> options
            :base(options)
            { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ICS-LT-7YWKQ73;Database=moviesdb;Trusted_Connection=True");
            }
            
        }

    }
}
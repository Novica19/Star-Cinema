using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StarCinema.Models
{
    public class MoviesContext: IdentityDbContext<AppUser>
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<User> Users { get; set; }
        public MoviesContext() : base("DefaultConnection2")
        {
        }
        public static MoviesContext Create()
        {
            return new MoviesContext(); 
        }

        public System.Data.Entity.DbSet<StarCinema.Models.Bilet> Bilets { get; set; }

        public System.Data.Entity.DbSet<StarCinema.Models.CreditCard> CreditCards { get; set; }
    }
}
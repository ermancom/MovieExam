using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Movie.Entities;

namespace Movie.Database
{
    public class MovieDbContext : DbContext
    {
        public DbSet<Movie.Entities.Movie> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<MovieRate> MovieRates {get; set;}

        public MovieDbContext(DbContextOptions options)
            :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
                        
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        
            base.OnConfiguring(optionsBuilder);
        }
    }
}

using Microsoft.AspNetCore.Components.Routing;
using Microsoft.EntityFrameworkCore;
using RickandMortyWebApp.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace RickandMortyWebApp.Data
{
    public class RickMortyContext : DbContext
    {
        public RickMortyContext(DbContextOptions<RickMortyContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Eroot>().HasNoKey();
            modelBuilder.Entity<Info>().HasNoKey();
        }
        


        public DbSet<Croot> Croot { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Origin> Origin { get; set; }
        public DbSet<Info> Info { get; set; }
        public DbSet<Result> Result{ get; set; }
        public DbSet<Eroot> Eroot { get; set; }

    }
}

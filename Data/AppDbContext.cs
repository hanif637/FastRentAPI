using FastRentAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FastRentAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
            modelBuilder.Entity<Vehicle>().ToTable("vehicles");
            modelBuilder.Entity<Rental>().ToTable("rentals");
        }
    }
}
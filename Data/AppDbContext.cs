using Microsoft.EntityFrameworkCore;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor: receives configuration from Program.cs
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // This represents the Products table in the database
        public DbSet<Product> Products { get; set; }

        // Precision information for decimals. Total digits = 18, Digits after dedcimal = 2.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);
        }
    }
}
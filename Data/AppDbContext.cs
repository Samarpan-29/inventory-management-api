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
    }
}
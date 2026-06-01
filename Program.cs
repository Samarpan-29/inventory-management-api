using InventoryManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using InventoryManagementSystem.Interfaces;
using InventoryManagementSystem.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// Add DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

// Configure middleware
app.UseAuthorization();

app.MapControllers();

app.Run();
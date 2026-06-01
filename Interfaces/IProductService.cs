using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
    }
}
using MyApp.Domain.Entities;

namespace MyApp.Logic.Interfaces
{
    public interface IProductRepository
    {
        Task AddAsync(Product product);
        Task<List<Product>> GetAllAsync();
    }

}

using MyApp.Domain.Entities;
using MyApp.Logic.Interfaces;

namespace MyApp.Logic.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public async Task CreateAsync(string name, decimal price)
        {
            var product = new Product(name, price);
            await _repo.AddAsync(product);
        }
        public async Task<List<Product>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }
    }
}

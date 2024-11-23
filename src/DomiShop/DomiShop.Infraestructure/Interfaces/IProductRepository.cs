using DomiShop.Domain.Entities;

namespace DomiShop.Infrastructure.Interfaces
{
    public interface IProductRepository
    {
        Task<Producto?> GetByIdAsync(int id);
        Task<IEnumerable<Producto>> GetAllAsync();
        Task AddAsync(Producto product);
        Task UpdateAsync(Producto product);
        Task DeleteAsync(Producto product);
    }
}

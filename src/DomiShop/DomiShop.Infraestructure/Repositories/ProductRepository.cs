using DomiShop.Domain.Entities;
using DomiShop.Infrastructure.Context;
using DomiShop.Infrastructure.Core;
using DomiShop.Infrastructure.Interfaces;

namespace DomiShop.Infrastructure.Repositories
{
    public class ProductRepository : BaseRepository<Producto>, IProductRepository
    {
        public ProductRepository(DomiShopContext context) : base(context) { }
    }
}

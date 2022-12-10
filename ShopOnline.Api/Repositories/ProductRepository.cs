using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Database;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ShopOnlineDbContext shopOnlineDbContext;

        public ProductRepository(ShopOnlineDbContext shopOnlineDbContext) : base( shopOnlineDbContext)
        {
            this.shopOnlineDbContext = shopOnlineDbContext;
        }
    }
}

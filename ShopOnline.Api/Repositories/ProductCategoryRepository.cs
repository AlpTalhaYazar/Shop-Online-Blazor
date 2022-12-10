using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Database;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;
using System.Runtime.CompilerServices;

namespace ShopOnline.Api.Repositories
{
    public class ProductCategoryRepository : GenericRepository<ProductCategory>, IProductCategoryRepository
    {
        private readonly ShopOnlineDbContext shopOnlineDbContext;

        public ProductCategoryRepository(ShopOnlineDbContext shopOnlineDbContext) : base(shopOnlineDbContext)
        {
            this.shopOnlineDbContext = shopOnlineDbContext;
        }
    }
}

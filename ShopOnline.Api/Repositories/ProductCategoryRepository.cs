using ShopOnline.Api.Database;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Repositories;

public class ProductCategoryRepository : GenericRepository<ProductCategory>, IProductCategoryRepository
{
    public ProductCategoryRepository(ShopOnlineDbContext shopOnlineDbContext) : base(shopOnlineDbContext)
    {
    }
}
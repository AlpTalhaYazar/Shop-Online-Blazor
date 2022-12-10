using ShopOnline.Api.Database;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Repositories
{
    public class CartRepository : GenericRepository<Cart>, ICartRepository
    {
        private readonly ShopOnlineDbContext shopOnlineDbContext;

        public CartRepository(ShopOnlineDbContext shopOnlineDbContext) : base(shopOnlineDbContext)
        {
            this.shopOnlineDbContext = shopOnlineDbContext;
        }
    }
}

using ShopOnline.Api.Database;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly ShopOnlineDbContext shopOnlineDbContext;
        
        public UserRepository(ShopOnlineDbContext shopOnlineDbContext) : base(shopOnlineDbContext)
        {
            this.shopOnlineDbContext = shopOnlineDbContext;
        }
    }
}

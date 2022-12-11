using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Controllers
{
    public class ProductController : GenericController<Product>
    {
        public ProductController(IGenericRepository<Product> genericRepository) : base(genericRepository)
        {
        }
    }
}

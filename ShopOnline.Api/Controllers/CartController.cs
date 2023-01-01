using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Controllers;

public class CartController : GenericController<Cart>
{
    public CartController(IGenericRepository<Cart> genericRepository) : base(genericRepository)
    {
    }
}
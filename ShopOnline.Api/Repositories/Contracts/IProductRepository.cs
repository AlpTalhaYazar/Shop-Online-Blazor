using ShopOnline.Api.Entities;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Api.Repositories.Contracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<ProductDto> GetProductByIdWithCategoryAsync(int id);
        Task<List<ProductDto>> GetProductsWithCategoryAsync();
    }
}

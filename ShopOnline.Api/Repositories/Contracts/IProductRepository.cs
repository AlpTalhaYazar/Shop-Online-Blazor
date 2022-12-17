using ShopOnline.Api.Entities;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Api.Repositories.Contracts
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<ProductWithCategoryDto> GetProductByIdWithCategoryAsync(int id);
        Task<List<ProductWithCategoryDto>> GetProductsWithCategoryAsync();
    }
}

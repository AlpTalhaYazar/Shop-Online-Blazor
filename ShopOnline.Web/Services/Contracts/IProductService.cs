using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Services.Contracts;

public interface IProductService
{
    Task<ProductWithCategoryDto> GetProductByIdWithCategoryAsync(int id);
    Task<IEnumerable<ProductWithCategoryDto>> GetProductsWithCategoryAsync();
}
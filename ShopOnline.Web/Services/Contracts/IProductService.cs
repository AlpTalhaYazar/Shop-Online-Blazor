using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Services.Contracts;

public interface IProductService
{
    Task<ProductDto> GetProductByIdWithCategoryAsync(int id);
    Task<IEnumerable<ProductDto>> GetProductsWithCategoryAsync();
}
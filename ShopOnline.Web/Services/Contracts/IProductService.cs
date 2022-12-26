using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Services.Contracts;

public interface IProductService
{
    Task<CustomResponseDto<ProductWithCategoryDto>> GetProductByIdWithCategoryAsync(int id);
    Task<CustomResponseDto<IEnumerable<ProductWithCategoryDto>>> GetProductsWithCategoryAsync();
}
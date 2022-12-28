using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;

namespace ShopOnline.Web.Pages.ProductPages;

public class ProductsBase : ComponentBase
{
    [Inject] public IProductService ProductService { get; set; }

    public IEnumerable<ProductWithCategoryDto> Products { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Products = (await ProductService.GetProductsWithCategoryAsync()).Data;
    }

    protected IOrderedEnumerable<IGrouping<int, ProductWithCategoryDto>> GetGroupedProductsByCategory() =>
        Products.GroupBy(p => p.CategoryId).OrderBy(g => g.Key);

    protected string GetCategoryName(IGrouping<int, ProductWithCategoryDto> groupedProducts) =>
        groupedProducts.FirstOrDefault(p => p.CategoryId == groupedProducts.Key).CategoryName;

    protected IEnumerable<ProductWithCategoryDto> GetProductsByCategory(int categoryId) =>
        Products.Where(p => p.CategoryId == categoryId);
}
using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;

namespace ShopOnline.Web.Pages.ProductPages;

public class ProductsBase : ComponentBase
{
    [Inject]
    public IProductService ProductService { get; set; }

    public IEnumerable<ProductWithCategoryDto> Products { get; set; }

    protected override async Task OnInitializedAsync()
    {
        Products = await ProductService.GetProductsWithCategoryAsync();
    }
}

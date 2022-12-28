using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;

namespace ShopOnline.Web.Pages.ProductPages;

public class ProductDetailsBase : ComponentBase
{
    [Parameter]
    public int Id { get; set; }

    [Inject]
    public IProductService ProductService { get; set; }

    public ProductWithCategoryDto? ProductWithCategory { get; set; }
    public List<string> Errors { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var response = await ProductService.GetProductByIdWithCategoryAsync(Id);
        
        ProductWithCategory = response?.Data;
        Errors = response?.Errors;
    }
}

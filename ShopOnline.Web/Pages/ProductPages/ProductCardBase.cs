using Microsoft.AspNetCore.Components;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Pages.ProductPages;

public class ProductCardBase : ComponentBase
{
    [Parameter]
    public IEnumerable<ProductWithCategoryDto> ProductsWithCategory { get; set; }
}
using ShopOnline.Models.Dtos;
using ShopOnline.Web.Services.Contracts;
using System.Net.Http.Json;

namespace ShopOnline.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<CustomResponseDto<ProductWithCategoryDto>> GetProductByIdWithCategoryAsync(int id)
        {
            var response = await httpClient.GetAsync($"/api/v1/ProductWithCategory/{id}");

            var responseContent = await response.Content.ReadFromJsonAsync<CustomResponseDto<ProductWithCategoryDto>>();

            return responseContent;
        }

        public async Task<CustomResponseDto<IEnumerable<ProductWithCategoryDto>>> GetProductsWithCategoryAsync()
        {
            var response = await httpClient.GetAsync("api/v1/ProductWithCategory");

            var responseContent =
                await response.Content.ReadFromJsonAsync<CustomResponseDto<IEnumerable<ProductWithCategoryDto>>>();

            return responseContent;
        }
    }
}
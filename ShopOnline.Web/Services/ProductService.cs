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

        public Task<ProductDto> GetProductByIdWithCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ProductDto>> GetProductsWithCategoryAsync()
        {
            var response = await httpClient.GetFromJsonAsync<CustomResponseDto<IEnumerable<ProductDto>>>("api/v1/Product/GetProductsWithCategory");

            var products = response.Data;

            return products;
        }
    }
}

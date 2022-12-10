using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Repositories.Contracts
{
    public interface IProductRepository
    {
        Task<Product> GetProduct(int id);
        Task<IEnumerable<Product>> GetProducts();
        Task<ProductCategory> GetProductCategory(int id);
        Task<IEnumerable<ProductCategory>> GetProductCategories();
    }
}

using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Database;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Api.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(ShopOnlineDbContext shopOnlineDbContext) : base(shopOnlineDbContext)
    {
    }

    public async Task<ProductWithCategoryDto> GetProductByIdWithCategoryAsync(int id)
    {
        // get product by id and include category and return as productdto
        var product = await shopOnlineDbContext.Products
            .Include(x => x.ProductCategory)
            .Where(x => x.Id == id)
            .Select(x => new ProductWithCategoryDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImageURL = x.ImageURL,
                Price = x.Price,
                Quantity = x.Quantity,
                CategoryId = x.CategoryId,
                CategoryName = x.ProductCategory.Name
            }).FirstOrDefaultAsync();

        return product;
    }

    public async Task<List<ProductWithCategoryDto>> GetProductsWithCategoryAsync()
    {
        var products = await shopOnlineDbContext.Products
            .Include(x => x.ProductCategory)
            .Select(x => new ProductWithCategoryDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                ImageURL = x.ImageURL,
                Price = x.Price,
                Quantity = x.Quantity,
                CategoryId = x.CategoryId,
                CategoryName = x.ProductCategory.Name
            }).ToListAsync();

        return products;
    }
}
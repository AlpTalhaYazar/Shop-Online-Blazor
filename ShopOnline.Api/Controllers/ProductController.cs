using Microsoft.AspNetCore.Mvc;
using ShopOnline.Api.Entities;
using ShopOnline.Api.Repositories.Contracts;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Api.Controllers;

public class ProductController : GenericController<Product>
{
    private readonly IProductRepository productRepository;

    public ProductController(IGenericRepository<Product> genericRepository, IProductRepository productRepository) : base(genericRepository)
    {
        this.productRepository = productRepository;
    }

    [HttpGet]
    [Route("/api/v1/ProductWithCategory/{id}")]
    public async Task<IActionResult> GetProductByIdWithCategory(int id)
    {
        var response = await productRepository.GetProductByIdWithCategoryAsync(id);

        if (response != null)
            return CreateActionResult(
                CustomResponseDto<ProductWithCategoryDto>.Success(StatusCodes.Status200OK, response));

        return CreateActionResult(
            CustomResponseDto<ProductWithCategoryDto>.Fail(StatusCodes.Status200OK, "No Entry Found"));
    }

    [HttpGet]
    [Route("/api/v1/ProductWithCategory")]
    public async Task<IActionResult> GetProductsWithCategory()
    {
        var response = await productRepository.GetProductsWithCategoryAsync();

        if (response != null)
            return CreateActionResult(
                CustomResponseDto<IEnumerable<ProductWithCategoryDto>>.Success(StatusCodes.Status200OK, response));

        return CreateActionResult(
            CustomResponseDto<IEnumerable<ProductWithCategoryDto>>.Fail(StatusCodes.Status200OK, "No Entry Found"));
    }
}
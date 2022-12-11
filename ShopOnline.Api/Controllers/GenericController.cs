using Microsoft.AspNetCore.Mvc;
using ShopOnline.Api.Repositories.Contracts;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Api.Controllers
{
    public abstract class GenericController<T> : CustomBaseController where T : class
    {
        protected readonly IGenericRepository<T> genericRepository;

        public GenericController(IGenericRepository<T> genericRepository)
        {
            this.genericRepository = genericRepository;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var response = await genericRepository.GetByIdAsync(id);

            if (response == null)
                return CreateActionResult(CustomResponseDto<T>.Fail(StatusCodes.Status404NotFound, "No Entry Found"));

            return CreateActionResult(CustomResponseDto<T>.Success(StatusCodes.Status200OK, response));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await genericRepository.GetAllAsync();

            if (response == null)
                return CreateActionResult(CustomResponseDto<T>.Fail(StatusCodes.Status404NotFound, "No Entry Found"));

            return CreateActionResult(CustomResponseDto<IEnumerable<T>>.Success(StatusCodes.Status200OK, response));
        }

    }
}
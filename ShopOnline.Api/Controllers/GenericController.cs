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
                return CreateActionResult(CustomResponseDto<T>.Fail(StatusCodes.Status200OK, "No Entry Found"));

            return CreateActionResult(CustomResponseDto<T>.Success(StatusCodes.Status200OK, response));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await genericRepository.GetAllAsync();

            if (response == null)
                return CreateActionResult(CustomResponseDto<T>.Fail(StatusCodes.Status200OK, "No Entry Found"));

            return CreateActionResult(CustomResponseDto<IEnumerable<T>>.Success(StatusCodes.Status200OK, response));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] T entity)
        {
            var response = await genericRepository.AddAsync(entity);

            if (response == null)
                return CreateActionResult(CustomResponseDto<T>.Fail(StatusCodes.Status400BadRequest, "Couldn't Create Entry"));

            return CreateActionResult(CustomResponseDto<T>.Success(StatusCodes.Status201Created, response));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] T entity)
        {
            var response = await genericRepository.UpdateAsync(entity);

            if (response == null)
                return CreateActionResult(CustomResponseDto<T>.Fail(StatusCodes.Status400BadRequest, "Couldn't Update Entry"));

            return CreateActionResult(CustomResponseDto<T>.Success(StatusCodes.Status200OK, response));
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await genericRepository.GetByIdAsync(id);

            if (entity == null)
                return CreateActionResult(CustomResponseDto<T>.Fail(StatusCodes.Status404NotFound, "No Entry Found"));

            await genericRepository.DeleteAsync(entity);

            return CreateActionResult(CustomResponseDto<T>.Success(StatusCodes.Status204NoContent));
        }
    }
}
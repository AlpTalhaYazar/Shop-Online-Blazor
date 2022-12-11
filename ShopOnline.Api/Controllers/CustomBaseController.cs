using Microsoft.AspNetCore.Mvc;
using ShopOnline.Models.Dtos;

namespace ShopOnline.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public abstract class CustomBaseController : ControllerBase
    {
        [NonAction]
        public IActionResult CreateActionResult<T>(CustomResponseDto<T> customResponseDto)
        {
            var httpResponse = new ObjectResult(customResponseDto) { StatusCode = customResponseDto.StatusCode };

            return httpResponse;
        }
    }
}

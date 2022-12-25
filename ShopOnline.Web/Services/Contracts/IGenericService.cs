using ShopOnline.Models.Dtos;

namespace ShopOnline.Web.Services.Contracts;

public interface IGenericService<T> where T : class
{
    Task<CustomResponseDto<T>> GetByIdAsync(int id);
    Task<CustomResponseDto<IEnumerable<T>>> GetAllAsync();
    Task<CustomResponseDto<T>> AddAsync(T entity);
    Task<CustomResponseDto<T>> UpdateAsync(T entity);
    Task<CustomResponseDto<T>> DeleteAsync(T entity);
}
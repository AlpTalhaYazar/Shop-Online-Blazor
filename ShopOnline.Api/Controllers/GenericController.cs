using ShopOnline.Api.Repositories.Contracts;

namespace ShopOnline.Api.Controllers
{
    public abstract class GenericController<T> : CustomBaseController where T : class
    {
        protected readonly IGenericRepository<T> genericRepository;

        public GenericController(IGenericRepository<T> genericRepository)
        {
            this.genericRepository = genericRepository;
        }
    }
}
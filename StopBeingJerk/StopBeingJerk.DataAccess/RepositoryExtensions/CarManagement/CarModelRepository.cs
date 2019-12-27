using StopBeingJerk.Domain.Entities;
using System.Linq;


namespace StopBeingJerk.DataAccess.Extensions
{
    public static class CarModelRepository
    {
        public static IQueryable<CarModel> GetAllCarBrandModels(this IRepository<CarModel> repository, int id)
        {
            return repository.Filter(x => x.BrandId == id);
        }
    }
}

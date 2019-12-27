using StopBeingJerk.Domain.Entities;
using System.Linq;

namespace StopBeingJerk.DataAccess.Extensions
{
    public static class CarInfoCardRepository
    {
        public static IQueryable<CarInfoCard> GetAllCarInfoCardsByRegistrationNumberId(this IRepository<CarInfoCard> repository, int id)
        {
            return repository.Filter(x => x.RegistrationNumberId == id);
        }
    }
}

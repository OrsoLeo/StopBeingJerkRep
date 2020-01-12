
using Microsoft.EntityFrameworkCore;
using StopBeingJerk.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StopBeingJerk.DataAccess.RepositoryExtensions.CarManagement
{
    public static class RegistrationNumberRepository
    {
        public async static Task<RegistrationNumber> GetRegistrationNumber(this IRepository<RegistrationNumber> repository, string number)
        {
            return await repository
                .Set
                .FirstOrDefaultAsync(rn => rn.Number.ToLower().Trim() == number.ToLower().Trim());
        }
    }
}

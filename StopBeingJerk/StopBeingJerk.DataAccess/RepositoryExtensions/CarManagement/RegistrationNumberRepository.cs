
using StopBeingJerk.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace StopBeingJerk.DataAccess.RepositoryExtensions.CarManagement
{
    public static class RegistrationNumberRepository
    {
        public static ICollection<Comment> GetAllCommentsByNumber(this IRepository<RegistrationNumber> repository, string number)
        {
            return repository
                .Filter(rn => rn.Number.ToLower().Trim() == number.ToLower().Trim())
                .Single()
                .Comments;
        }
    }
}

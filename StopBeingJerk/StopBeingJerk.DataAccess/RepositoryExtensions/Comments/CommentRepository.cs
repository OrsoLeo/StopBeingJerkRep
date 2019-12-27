
using StopBeingJerk.Domain.Entities;
using System.Linq;

namespace StopBeingJerk.DataAccess.RepositoryExtensions.Comments
{
    public static class CommentRepository
    {
        public static IQueryable<Comment> GetAllCommentsByNumber(this IRepository<Comment> repository, string number)
        {
            return repository.Filter(c => c.RegistrationNumber.Number.ToLower().Trim() == number.ToLower().Trim());
        }
    }
}

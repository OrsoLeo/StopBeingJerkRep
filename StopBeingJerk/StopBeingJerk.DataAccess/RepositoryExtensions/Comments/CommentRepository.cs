
using Microsoft.EntityFrameworkCore;
using StopBeingJerk.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StopBeingJerk.DataAccess.RepositoryExtensions.Comments
{
    public static class CommentRepository
    {
        public static async Task<IEnumerable<Comment>> GetAllCommentsByNumber(this IRepository<Comment> repository, string number)
        {
            return await repository.Filter(c => c.RegistrationNumber.Number.ToLower().Trim() == number.ToLower().Trim()).ToListAsync();
        }
    }
}

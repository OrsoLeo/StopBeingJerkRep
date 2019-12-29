using StopBeingJerk.Dto.Comments;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StopBeingJerk.ApplicationLogic.Comments
{
    public interface ICommentService
    {
        Task<IEnumerable<CommentDto>> GetAllCommentsByNumber(string number);
    }
}
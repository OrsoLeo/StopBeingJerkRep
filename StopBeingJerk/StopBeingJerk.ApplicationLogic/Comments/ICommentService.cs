using StopBeingJerk.Dto.Comments;
using StopBeingJerk.Dto.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StopBeingJerk.ApplicationLogic.Comments
{
    public interface ICommentService
    {
        Task<IEnumerable<CommentDto>> GetAllCommentsByNumber(string number);
        Task<CommentDto> CreateOrUpdateComment(CommentDto dto);
        IEnumerable<AutoCompleteDto> GetAllCommentTopics();
    }
}
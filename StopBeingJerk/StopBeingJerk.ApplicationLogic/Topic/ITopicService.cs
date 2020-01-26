using StopBeingJerk.Dto.Comments;
using StopBeingJerk.Dto.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StopBeingJerk.ApplicationLogic.Topic
{
    public interface ITopicService
    {
        Task<CommentTopicDto> CreateOrUpdateComment(CommentTopicDto dto);
        Task<IEnumerable<AutoCompleteDto>> GetAllCommentTopics();
    }
}
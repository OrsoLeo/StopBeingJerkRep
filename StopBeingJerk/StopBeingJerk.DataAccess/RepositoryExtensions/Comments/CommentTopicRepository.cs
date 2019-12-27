using StopBeingJerk.Domain.Entities;
using System.Linq;

namespace StopBeingJerk.DataAccess.Comments
{
    public static class CommentTopicRepository
    {
        public static IQueryable<CommentTopic> GetAllUnreadComments(this IRepository<CommentTopic> repository)
        {
            return repository.Filter(x => x.TopicName == "asdasd");
        }
    }
}



namespace StopBeingJerk.Dto.Comments
{
    public class CommentTopicDto
    {
        public int Id { get; set; }
        public string TopicName { get; set; }
        public int? TopicTypeId { get; set; }

        public CommentTopicTypeDto TopicType { get; set; }
        //public virtual ICollection<CommentDto> Comments { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace StopBeingJerk.Domain.Entities
{
    public partial class CommentTopic
    {
        public CommentTopic()
        {
            Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string TopicName { get; set; }
        public int? TopicTypeId { get; set; }

        public virtual CommentTopicType TopicType { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}

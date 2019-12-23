using System;
using System.Collections.Generic;

namespace StopBeingJerk.Domain.Entities
{
    public partial class CommentTopic
    {
        public CommentTopic()
        {
            CommentInfoCards = new HashSet<CommentInfoCard>();
        }

        public int Id { get; set; }
        public string TopicName { get; set; }
        public int? TopicTypeId { get; set; }

        public virtual CommentTopicType TopicType { get; set; }
        public virtual ICollection<CommentInfoCard> CommentInfoCards { get; set; }
    }
}

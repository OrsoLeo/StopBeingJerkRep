using System;
using System.Collections.Generic;

namespace StopBeingJerk.Domain.Entities
{
    public partial class CommentTopicType
    {
        public CommentTopicType()
        {
            CommentTopics = new HashSet<CommentTopic>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<CommentTopic> CommentTopics { get; set; }
    }
}

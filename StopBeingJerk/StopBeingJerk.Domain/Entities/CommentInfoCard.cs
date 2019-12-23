using System;
using System.Collections.Generic;

namespace StopBeingJerk.Domain.Entities
{
    public partial class CommentInfoCard
    {
        public CommentInfoCard()
        {
            Comments = new HashSet<Comment>();
            PhotoInfoCards = new HashSet<PhotoInfoCard>();
        }

        public int Id { get; set; }
        public int CommentTopicId { get; set; }
        public int CarInfoCardId { get; set; }

        public virtual CarInfoCard CarInfoCard { get; set; }
        public virtual CommentTopic CommentTopic { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<PhotoInfoCard> PhotoInfoCards { get; set; }
    }
}

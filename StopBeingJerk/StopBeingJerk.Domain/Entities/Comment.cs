using System;
using System.Collections.Generic;

namespace StopBeingJerk.Domain.Entities
{
    public partial class Comment
    {
        public int Id { get; set; }
        public string CommentDescription { get; set; }
        public int CommentInfoCardId { get; set; }
        public DateTime? CommentDate { get; set; }

        public virtual CommentInfoCard CommentInfoCard { get; set; }
    }
}

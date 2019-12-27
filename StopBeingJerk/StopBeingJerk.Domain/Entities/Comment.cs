using System;
using System.Collections.Generic;

namespace StopBeingJerk.Domain.Entities

{
    public partial class Comment
    {
        public Comment()
        {
            PhotoInfoCards = new HashSet<PhotoInfoCard>();
        }

        public int Id { get; set; }
        public int? RegistrationNumberId { get; set; }
        public int CommentTopicId { get; set; }
        public string CommentDescription { get; set; }
        public DateTime? CommentDate { get; set; }

        public virtual CommentTopic CommentTopic { get; set; }
        public virtual RegistrationNumber RegistrationNumber { get; set; }
        public virtual ICollection<PhotoInfoCard> PhotoInfoCards { get; set; }
    }
}

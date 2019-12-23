using System;
using System.Collections.Generic;

namespace StopBeingJerk.Domain.Entities
{
    public partial class PhotoInfoCard
    {
        public int Id { get; set; }
        public int CommentInfoCardId { get; set; }
        public int PhotoId { get; set; }

        public virtual CommentInfoCard CommentInfoCard { get; set; }
        public virtual Photo Photo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace StopBeingJerk.Dto.CarManagement
{
    public class CommentOutput
    {
        public int Id { get; set; }
        public int CommentTopicId { get; set; }
        public string CommentDescription { get; set; }
        //public DateTimeOffset? CommentDate { get; set; }
    }
}

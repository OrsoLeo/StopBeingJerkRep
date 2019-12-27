
using System;

namespace StopBeingJerk.Dto.Comments
{
    public class CommentDto
    {
        public int Id { get; set; }
        public int RegistrationNumberId { get; set; }
        public int CommentTopicId { get; set; }
        public string CommentDescription { get; set; }
        public DateTime CommentDate { get; set; }

        public CommentTopicDto CommentTopic { get; set; }
        public RegistrationNumberDto RegistrationNumber { get; set; }
    }
}

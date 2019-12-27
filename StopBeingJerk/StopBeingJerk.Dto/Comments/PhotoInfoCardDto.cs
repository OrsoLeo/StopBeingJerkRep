
namespace StopBeingJerk.Dto.Comments
{
    public class PhotoInfoCardDto
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public int PhotoId { get; set; }

        public CommentDto Comment { get; set; }
        public PhotoDto Photo { get; set; }
    }
}

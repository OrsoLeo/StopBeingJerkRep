
using System.Collections.Generic;

namespace StopBeingJerk.Dto.Comments
{
    public class PhotoDto
    {
        public int Id { get; set; }
        public string PhotoData { get; set; }
        public string PhotoExtension { get; set; }

        public ICollection<PhotoInfoCardDto> PhotoInfoCards { get; set; }
    }
}

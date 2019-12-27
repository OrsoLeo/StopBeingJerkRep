
using System.Collections.Generic;

namespace StopBeingJerk.Dto.Comments
{
    public class RegistrationNumberDto
    {
        public int Id { get; set; }
        public string Number { get; set; }

        public ICollection<CarInfoCardDto> CarInfoCards { get; set; }
        public ICollection<CommentDto> Comments { get; set; }
    }
}

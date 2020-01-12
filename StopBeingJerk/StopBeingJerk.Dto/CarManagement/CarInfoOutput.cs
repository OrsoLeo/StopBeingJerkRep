using StopBeingJerk.Dto.Comments;
using System.Collections.Generic;

namespace StopBeingJerk.Dto.CarManagement
{
    public class CarInfoOutput
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public ICollection<CarInfoCardDto> CarInfoCards { get; set; }
        public ICollection<CommentDto> Comments { get; set; }
    }
}

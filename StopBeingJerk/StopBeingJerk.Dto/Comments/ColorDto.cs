
using System.Collections.Generic;

namespace StopBeingJerk.Dto.Comments
{
    public class ColorDto
    {
        public int Id { get; set; }
        public string ColorName { get; set; }

        public ICollection<CarInfoCardDto> CarInfoCards { get; set; }
    }
}

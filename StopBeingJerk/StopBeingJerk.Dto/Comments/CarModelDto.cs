using System.Collections.Generic;

namespace StopBeingJerk.Dto.Comments
{
    public class CarModelDto
    {
        public int Id { get; set; }
        public string ModelName { get; set; }
        public int BrandId { get; set; }

        public CarBrandDto Brand { get; set; }
        public ICollection<CarInfoCardDto> CarInfoCards { get; set; }
    }
}

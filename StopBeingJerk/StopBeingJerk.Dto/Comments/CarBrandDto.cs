using System.Collections.Generic;

namespace StopBeingJerk.Dto.Comments
{
    public class CarBrandDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; }

        public ICollection<CarModelDto> CarModels { get; set; }
    }
}

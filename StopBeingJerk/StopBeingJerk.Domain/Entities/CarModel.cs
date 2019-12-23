using System;
using System.Collections.Generic;

namespace StopBeingJerk.Domain.Entities
{
    public partial class CarModel
    {
        public CarModel()
        {
            CarInfoCards = new HashSet<CarInfoCard>();
        }

        public int Id { get; set; }
        public string ModelName { get; set; }
        public int? BrandId { get; set; }

        public virtual CarBrand Brand { get; set; }
        public virtual ICollection<CarInfoCard> CarInfoCards { get; set; }
    }
}

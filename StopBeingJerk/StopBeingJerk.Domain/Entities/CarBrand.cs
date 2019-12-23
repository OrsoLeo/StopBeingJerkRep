using System;
using System.Collections.Generic;

namespace StopBeingJerk.Domain.Entities
{
    public partial class CarBrand
    {
        public CarBrand()
        {
            CarModels = new HashSet<CarModel>();
        }

        public int Id { get; set; }
        public string BrandName { get; set; }

        public virtual ICollection<CarModel> CarModels { get; set; }
    }
}

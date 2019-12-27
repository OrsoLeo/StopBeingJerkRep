using System;
using System.Collections.Generic;

namespace StopBeingJerk.Domain.Entities
{
    public partial class CarInfoCard
    {
        public int Id { get; set; }
        public int? ModelId { get; set; }
        public int? ColorId { get; set; }
        public int? RegistrationNumberId { get; set; }

        public virtual Color Color { get; set; }
        public virtual CarModel Model { get; set; }
        public virtual RegistrationNumber RegistrationNumber { get; set; }
    }
}

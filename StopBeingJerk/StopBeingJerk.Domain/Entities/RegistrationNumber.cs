using System;
using System.Collections.Generic;

namespace StopBeingJerk.Domain.Entities
{
    public partial class RegistrationNumber
    {
        public RegistrationNumber()
        {
            CarInfoCards = new HashSet<CarInfoCard>();
        }

        public int Id { get; set; }
        public string Number { get; set; }

        public virtual ICollection<CarInfoCard> CarInfoCards { get; set; }
    }
}

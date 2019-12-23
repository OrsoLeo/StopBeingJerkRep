using System;
using System.Collections.Generic;

namespace StopBeingJerk.Domain.Entities
{
    public partial class Color
    {
        public Color()
        {
            CarInfoCards = new HashSet<CarInfoCard>();
        }

        public int Id { get; set; }
        public string ColorName { get; set; }

        public virtual ICollection<CarInfoCard> CarInfoCards { get; set; }
    }
}

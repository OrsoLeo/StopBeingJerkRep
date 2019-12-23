using System;
using System.Collections.Generic;

namespace StopBeingJerk.Domain.Entities
{
    public partial class Photo
    {
        public Photo()
        {
            PhotoInfoCards = new HashSet<PhotoInfoCard>();
        }

        public int Id { get; set; }
        public string PhotoData { get; set; }
        public string PhotoExtension { get; set; }

        public virtual ICollection<PhotoInfoCard> PhotoInfoCards { get; set; }
    }
}

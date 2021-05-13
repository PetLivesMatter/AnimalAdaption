using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class AdvertisemetDetailDto : IDto
    {
        public int AdvertisementId { get; set; }
        public int AnimalId { get; set; }
        public int OwningId { get; set; }
        public int EmbracingId { get; set; }
        public DateTime AdvertisementDate { get; set; }
    }
}

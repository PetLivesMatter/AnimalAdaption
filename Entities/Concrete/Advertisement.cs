using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Advertisement : IEntity
    {
        public int AdvertisementId { get; set; }
        public int AnimalId { get; set; }
        public int OwningId { get; set; }
        public int EmbracingId { get; set; }
        public DateTime AdvertisementDate { get; set; }
    }
}

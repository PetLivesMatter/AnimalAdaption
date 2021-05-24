using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Advertisement : IEntity
    {
        public int AdvertisementId { get; set; }
        public int AnimalId { get; set; }
        public int UserId { get; set; }
        public DateTime AdvertisementDate { get; set; }
    }
}

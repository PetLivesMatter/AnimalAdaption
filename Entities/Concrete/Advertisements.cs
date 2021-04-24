using System;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Advertisements : IEntity
    {
        public int AdvertisementsId { get; set; }
        public int AnimalId { get; set; }
        public int SahiplenenId { get; set; }
        public int SahiplendirenId { get; set; }
        public DateTime AdvertisementsDate { get; set; }
    }
}

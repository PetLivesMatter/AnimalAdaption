    using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Advertisements
    {
        public int AdvertisementsId { get; set; }
        public int AnimalId { get; set; }
        public int SahiplenenId { get; set; }
        public int SahiplendirenId { get; set; }
        public DateTime AdvertisementsDate { get; set; }
    }
}

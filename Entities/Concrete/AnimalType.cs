using Core.Entities;

namespace Entities.Concrete
{
    public class AnimalType : IEntity
    {
        public int AnimalTypeId { get; set; }
        public string AnimalTypeName { get; set; }
        public string Description { get; set; }

    }
}

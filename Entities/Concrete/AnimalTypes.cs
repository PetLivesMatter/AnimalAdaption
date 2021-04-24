using Entities.Abstract;

namespace Entities.Concrete
{
    public class AnimalTypes : IEntity
    {
        public int AnimalTypesId { get; set; }
        public string AnimalTypesName { get; set; }
        public string Description { get; set; }

    }
}

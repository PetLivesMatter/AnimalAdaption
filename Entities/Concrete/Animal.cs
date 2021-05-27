using Core.Entities;

namespace Entities.Concrete
{
    public class Animal : IEntity
    {
        public int AnimalId { get; set; }
        public int AnimalTypeId { get; set; }
        public string AnimalName { get; set; }
        public string AnimalGender { get; set; } 
        public string AnimalAge { get; set; }
        public int Address { get; set; }
    }
}

using Core.Entities;

namespace Entities.Concrete
{
    public class Animal : IEntity
    {
        public int AnimalId { get; set; }
        public int AnimalTypesId { get; set; }
        public string AnimalName { get; set; }
        public float AnimalWeight { get; set; }
        public string AnimalGender { get; set; } 
        public int AnimalAge { get; set; }
        public string AnimalImage { get; set; }

    }
}

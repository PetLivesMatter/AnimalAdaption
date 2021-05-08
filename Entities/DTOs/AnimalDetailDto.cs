using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class AnimalDetailDto : IDto
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

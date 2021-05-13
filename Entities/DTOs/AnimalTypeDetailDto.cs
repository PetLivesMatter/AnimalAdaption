using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class AnimalTypeDetailDto : IDto
    {
        public int AnimalTypeId { get; set; }
        public string AnimalTypeName { get; set; }
        public string Description { get; set; }
    }
}

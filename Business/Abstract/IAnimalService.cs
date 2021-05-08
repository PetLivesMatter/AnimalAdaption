using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAnimalService
    {
        List<Animal> GetAll();
        List<Animal> GetAllByAnimalsTypeId(int Id);
        List<AnimalDetailDto> GetAnimalDetail();
    }
}

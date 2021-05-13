using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IAnimalService
    {
        IDataResult<List<Animal>> GetAll();
        IDataResult<List<Animal>> GetAllByAnimalsTypeId(int Id);
        IDataResult<List<AnimalDetailDto>> GetAnimalDetail();
        IResult Add(Animal animal);
        IDataResult<Animal> Delete(Animal animal);
        IDataResult<Animal> Update(Animal animal);
        IDataResult<Animal> GetById(int animalId);
    }
}

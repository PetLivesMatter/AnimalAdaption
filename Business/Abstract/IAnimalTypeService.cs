using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAnimalTypeService
    {
        IDataResult<List<AnimalType>> GetAll();
        IDataResult<List<AnimalTypeDetailDto>> GetAnimalTypeDetail();
        IResult Add(AnimalType animalType);
        IDataResult<AnimalType> Delete(AnimalType animalType);
        IDataResult<AnimalType> Update(AnimalType animalType);
        IDataResult<AnimalType> GetById(int animalTypeId);
    }
}

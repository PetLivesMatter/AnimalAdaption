using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;

namespace Business.Concrete
{
    public class AnimalTypeManager : IAnimalTypeService
    {
        IAnimalTypeDal _animalTypeDal;

        public AnimalTypeManager(IAnimalTypeDal animalTypeDal)
        {
            _animalTypeDal = animalTypeDal;

        }

        public IResult Add(AnimalType animalType)
        {
            _animalTypeDal.Add(animalType);
            return new SuccessResult(Messages.AnimalTypeAdded);
        }

        public IDataResult<AnimalType> Delete(AnimalType Id)
        {
            _animalTypeDal.Delete(Id);

            return new SuccessDataResult<AnimalType>(Messages.AnimalTypeDeleted);
        }

        public IDataResult<List<AnimalType>> GetAll()
        {
            return new SuccessDataResult<List<AnimalType>>(_animalTypeDal.GetAll(), Messages.AnimalTypeAll);
        }

        public IDataResult<List<AnimalTypeDetailDto>> GetAnimalTypeDetail()
        {
            return new SuccessDataResult<List<AnimalTypeDetailDto>>(_animalTypeDal.GetAnimalTypeDetail());
        }

        public IDataResult<AnimalType> GetById(int animalTypeId)
        {
            return new SuccessDataResult<AnimalType>(_animalTypeDal.Get(a => a.AnimalTypeId == animalTypeId));
        }

    }
}


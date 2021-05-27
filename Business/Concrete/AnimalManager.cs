using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;

namespace Business.Concrete
{
    public class AnimalManager : IAnimalService
    {
        readonly IAnimalDal _animalDal;

        public AnimalManager(IAnimalDal animalDal)
        {
            _animalDal = animalDal;

        }

        //[SecuredOperation("animal.add,admin")]
        [ValidationAspect(typeof(AnimalValidator))]
        public IResult Add(Animal animal)
        {
            _animalDal.Add(animal);

            return new SuccessResult(Messages.AnimalAdded);
        }

        [ValidationAspect(typeof(AnimalValidator))]
        public  IDataResult<Animal> Delete(Animal Id)
        {
             _animalDal.Delete(Id);

            return new SuccessDataResult<Animal>(Messages.AnimalDeleted);
        }

        [ValidationAspect(typeof(AnimalValidator))]
        public IDataResult<List<Animal>> GetAll()
        {
            
            return new SuccessDataResult<List<Animal>>(_animalDal.GetAll(), Messages.AnimalAll);
        }


        [ValidationAspect(typeof(AnimalValidator))]
        public IDataResult<List<Animal>> GetAllByAnimalsTypeId(int Id)
        {
            return new SuccessDataResult<List<Animal>>(_animalDal.GetAll(p => p.AnimalTypeId == Id));
        }

        [ValidationAspect(typeof(AnimalValidator))]
        public IDataResult<List<AnimalDetailDto>> GetAnimalDetail()
        {
            return new SuccessDataResult<List<AnimalDetailDto>>(_animalDal.GetAnimalDetail());
        }

        [ValidationAspect(typeof(AnimalValidator))]
        public IDataResult<Animal> GetById(int animalId)
        {
            return new SuccessDataResult<Animal>(_animalDal.Get(a => a.AnimalId == animalId));
        }

        [ValidationAspect(typeof(AnimalValidator))]
        public IDataResult<Animal> Update(Animal animal, string directoryPath)
        {
            Animal existedAnimal =  _animalDal.Get(a => a.AnimalId == animal.AnimalId);
            existedAnimal.AnimalName = string.IsNullOrEmpty(animal.AnimalName) ? existedAnimal.AnimalName : animal.AnimalName;
            existedAnimal.AnimalGender = string.IsNullOrEmpty(animal.AnimalGender) ? existedAnimal.AnimalGender : animal.AnimalGender;
            existedAnimal.AnimalAge = string.IsNullOrEmpty(animal.AnimalAge) ? existedAnimal.AnimalAge : animal.AnimalAge;

            _animalDal.Update(existedAnimal);
            return new SuccessDataResult<Animal>(Messages.AnimalUpdated);
        }
    }
}

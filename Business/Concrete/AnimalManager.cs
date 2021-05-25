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

        [SecuredOperation("animal.add,admin")]
        [ValidationAspect(typeof(AnimalValidator))]
        public IResult Add(Animal animal)
        {
            _animalDal.Add(animal);

            return new SuccessResult(Messages.AnimalAdded);
        }

        [ValidationAspect(typeof(AnimalValidator))]
        public IDataResult<Animal> Delete(Animal animal)
        {
            throw new NotImplementedException();
        }

        [ValidationAspect(typeof(AnimalValidator))]
        public IDataResult<List<Animal>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Animal>>(Messages.AnimalAdded);
            }
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
        public IDataResult<Animal> Update(Animal animal)
        {
            throw new NotImplementedException();
        }
    }
}

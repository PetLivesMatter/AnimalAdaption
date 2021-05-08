using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class AnimalManager : IAnimalService
    { 
        IAnimalDal _animalDal;

        public AnimalManager(IAnimalDal animalDal)
        {
            _animalDal = animalDal;

        }

        public List<Animal> GetAll()
        {
            return _animalDal.GetAll();
        }

        public List<Animal> GetAllByAnimalsTypeId(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Animal> GetAllByAnimalTypeId(int Id)
        {
            return _animalDal.GetAll(p => p.AnimalTypesId == Id); 
        }

        public List<AnimalDetailDto> GetAnimalDetail()
        {
            return _animalDal.GetAnimalDetail();
        }
    }
}

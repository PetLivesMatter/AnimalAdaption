using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAnimalTypesDal : IAnimalTypesDal
    {
        public void Add(AnimalTypes entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(AnimalTypes entity)
        {
            throw new NotImplementedException();
        }

        public AnimalTypes Get(Expression<Func<AnimalTypes, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<AnimalTypes> GetAll(Expression<Func<AnimalTypes, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(AnimalTypes entity)
        {
            throw new NotImplementedException();
        }
    }
}

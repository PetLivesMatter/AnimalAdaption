using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAnimalsDal : IAnimalsDal
    {
        public void Add(Animals entity)
        {
            using AnimalAdaptionContext context = new AnimalAdaptionContext()
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(Animals entity)
        {
            using AnimalAdaptionContext context = new AnimalAdaptionContext()
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public Animals Get(Expression<Func<Animals, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Animals> GetAll(Expression<Func<Animals, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Animals entity)
        {
            using (AnimalAdaptionContext context = new AnimalAdaptionContext()) 
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}

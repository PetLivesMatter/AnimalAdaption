using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAdvertisementsDal : IAdvertisementsDal
    {
        public void Add(Advertisements entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Advertisements entity)
        {
            throw new NotImplementedException();
        }

        public Advertisements Get(Expression<Func<Advertisements, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Advertisements> GetAll(Expression<Func<Advertisements, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Advertisements entity)
        {
            throw new NotImplementedException();
        }
    }
}

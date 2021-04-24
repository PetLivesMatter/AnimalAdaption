using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUsersDal : IUsersDal
    {
        public void Add(Users entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Users entity)
        {
            throw new NotImplementedException();
        }

        public Users Get(Expression<Func<Users, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Users> GetAll(Expression<Func<Users, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Users entity)
        {
            throw new NotImplementedException();
        }
    }
}

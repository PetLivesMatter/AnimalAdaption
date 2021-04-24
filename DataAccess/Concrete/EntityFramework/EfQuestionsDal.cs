using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfQuestionsDal : IQuestionsDal
    {
        public void Add(Questions entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Questions entity)
        {
            throw new NotImplementedException();
        }

        public Questions Get(Expression<Func<Questions, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Questions> GetAll(Expression<Func<Questions, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Questions entity)
        {
            throw new NotImplementedException();
        }
    }
}

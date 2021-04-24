using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAnswersDal : IAnswersDal
    {
        public void Add(Answers entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Answers entity)
        {
            throw new NotImplementedException();
        }

        public Answers Get(Expression<Func<Answers, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Answers> GetAll(Expression<Func<Answers, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Answers entity)
        {
            throw new NotImplementedException();
        }
    }
}

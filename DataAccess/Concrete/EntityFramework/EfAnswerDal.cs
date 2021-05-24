using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAnswerDal : EfEntityRepositoryBase<Answer, AnimalAdaptionContext>, IAnswerDal
    {
        public List<AnswerDetailDto> GetAnswerDetail()
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class EfQuestionDal : EfEntityRepositoryBase<Question, AdaptionProjectContext>, IQuestionDal
    {
        public List<QuestionDetailDto> GetQuestionDetail()
        {
            throw new NotImplementedException();
        }
    }
}

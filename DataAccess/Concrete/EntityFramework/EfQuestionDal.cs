using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfQuestionDal : EfEntityRepositoryBase<Question,AnimalAdaptionContext>,IQuestionDal
    {
        
    }
}

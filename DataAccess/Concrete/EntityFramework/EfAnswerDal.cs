﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAnswerDal :EfEntityRepositoryBase<Answer,AnimalAdaptionContext>,IAnswerDal
    {
        
    }
}

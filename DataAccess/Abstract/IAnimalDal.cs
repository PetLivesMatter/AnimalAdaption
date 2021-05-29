using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Core.DataAccess;
using Entities.DTOs;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IAnimalDal : IEntityRepository<Animal>
    {
        List<AnimalDetailDto> GetAnimalDetail(Expression<Func<AnimalDetailDto, bool>> filter = null);
    }
}

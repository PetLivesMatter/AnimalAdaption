using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAnimalDal : EfEntityRepositoryBase<Animal, AnimalAdaptionContext>, IAnimalDal
    {
        public List<AnimalDetailDto> GetAnimalDetail()
        {
            throw new NotImplementedException();
        }
    }
        /*public List<AnimalDetailDto> GetAnimalDetail()
        {
            using (AnimalAdaptionContext context = new AnimalAdaptionContext())
            {
                var result = from a in context.Animals
                    join t in context.AnimalTypes
                        on a.AnimalTypesId equals t.AnimalTypeId;

            }
            
        }*/
    }
}

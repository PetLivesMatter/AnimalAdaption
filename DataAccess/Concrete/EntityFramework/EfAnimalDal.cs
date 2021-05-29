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
    public class EfAnimalDal : EfEntityRepositoryBase<Animal, AdaptionProjectContext>, IAnimalDal
    {
        public List<AnimalDetailDto> GetAnimalDetail(Expression<Func<AnimalDetailDto, bool>> filter = null)
        {
            using (AdaptionProjectContext context = new AdaptionProjectContext())
            {
                var result = from animals in context.Animals
                             join types in context.AnimalTypes
                                 on animals.AnimalTypeId equals types.AnimalTypeId
                             select new AnimalDetailDto
                             {
                                 AnimalId = animals.AnimalId,
                                 Address = animals.Address,
                                 AnimalName = animals.AnimalName,
                                 AnimalAge = animals.AnimalAge,
                                 AnimalGender = animals.AnimalGender,
                                 AnimalTypeName = types.AnimalTypeName

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }


        }

    }
    
}


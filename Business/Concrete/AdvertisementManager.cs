using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class AdvertisementManager : IAdvertisementService
    {
        IAdvertisementDal _advertisementDal;

        public AdvertisementManager(IAdvertisementDal advertisementDal)
        {
            _advertisementDal = advertisementDal;

        }

        public IResult Add(Advertisement advertisement)
        {

            _advertisementDal.Add(advertisement);
            return new SuccessResult(Messages.AnimalAdded);
        }

        public IDataResult<Advertisement> Delete(Advertisement advertisement)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Advertisement>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Advertisement>>(Messages.AnimalAdded);
            }
            return new SuccessDataResult<List<Advertisement>>(_advertisementDal.GetAll(), Messages.AnimalAll);
        }

        public IDataResult<Advertisement> GetById(int advertisementId)
        {
            return new SuccessDataResult<Advertisement>(_advertisementDal.Get(a => a.AdvertisementId == advertisementId));
        }

        public IDataResult<Advertisement> Update(Advertisement advertisement)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<AdvertisemetDetailDto>> GetAdvertisementDetail()
        {
            return new SuccessDataResult<List<AdvertisemetDetailDto>>(_advertisementDal.GetAdvertisemetDetail());
        }
    }
}

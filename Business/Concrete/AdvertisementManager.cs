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
            return new SuccessResult(Messages.AdvertisementAdded);
        }

        public IDataResult<Advertisement> Delete(Advertisement Id)
        {
            _advertisementDal.Delete(Id);

            return new SuccessDataResult<Advertisement>(Messages.AdvertisementDeleted);
        }

        public IDataResult<List<Advertisement>> GetAll()
        {
            return new SuccessDataResult<List<Advertisement>>(_advertisementDal.GetAll(), Messages.AdvertisementAll);
        }

        public IDataResult<Advertisement> GetById(int advertisementId)
        {
            return new SuccessDataResult<Advertisement>(_advertisementDal.Get(a => a.AdvertisementId == advertisementId));
        }

        public IDataResult<List<AdvertisemetDetailDto>> GetAdvertisementDetail()
        {
            return new SuccessDataResult<List<AdvertisemetDetailDto>>(_advertisementDal.GetAdvertisemetDetail());
        }
    }
}

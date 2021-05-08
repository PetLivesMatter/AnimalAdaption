using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AdvertisementManager : IAdvertisementService
    {
        private IAdvertisementDal _advertisementDal;

        public AdvertisementManager(IAdvertisementDal advertisementDal)
        {
            _advertisementDal = advertisementDal;
        }

        public List<Advertisement> GetAll()
        {
            return _advertisementDal.GetAll();
        }
        // SELECT * FROM Advertisement where AdvertisementId = 3
        public List<Advertisement> GetById(int advertisementId)
        {
            return _advertisementDal.Get(a => a.AdvertisementId == advertisementId);
        }
    }  
}

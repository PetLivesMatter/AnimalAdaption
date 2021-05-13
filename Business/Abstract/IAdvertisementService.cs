using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IAdvertisementService
    {
        IDataResult<List<Advertisement>> GetAll();
        IDataResult<List<AdvertisemetDetailDto>> GetAdvertisementDetail();
        IResult Add(Advertisement advertisement);
        IDataResult<Advertisement> Delete(Advertisement advertisement);
        IDataResult<Advertisement> Update(Advertisement advertisement);
        IDataResult<Advertisement> GetById(int advertisementId);

    }
}

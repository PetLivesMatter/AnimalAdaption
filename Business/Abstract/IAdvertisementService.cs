using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAdvertisementService
    {
        List<Advertisement> GetAll();
        List<Advertisement> GetById(int advAdvertisementId);


    }
}

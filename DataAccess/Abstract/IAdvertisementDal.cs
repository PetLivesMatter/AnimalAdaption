﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Entities;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IAdvertisementDal : IEntityRepository<Advertisement>
    {
        List<AdvertisemetDetailDto> GetAdvertisemetDetail();
    }
}
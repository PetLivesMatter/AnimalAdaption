using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<UserDetailDto>> GetUserDetail();
        IResult Add(User user);
        IDataResult<User> Delete(User user);
        IDataResult<User> Update(User user);
        IDataResult<User> GetById(int userId);
    }
}
}

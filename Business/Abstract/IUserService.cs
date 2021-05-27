using Core.Entities.Concrete;
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
        IResult Add(User user);
        IDataResult<User> Delete(User user);
        IDataResult<User> Update(User user, string directoryPath);
        IDataResult<User> GetById(int userId);
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);
    }
}


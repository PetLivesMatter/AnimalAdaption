using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Identity;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;

        }

       
        public IResult Add(User user)
        {
            _userDal.Add(user);

            return new SuccessResult(Messages.UserAdded);
        }


        public IDataResult<User> Delete(User Id)
        {
            _userDal.Delete(Id);

            return new SuccessDataResult<User>(Messages.UserDeleted);
        }

        
        public IDataResult<List<User>> GetAll()
        {

            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserAll);
        }


        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(a => a.Id == userId));
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public IDataResult<User> Update(User user, string directoryPath)
        {
            User existedUser = _userDal.Get(a => a.Id == user.Id);
            existedUser.FirstName = string.IsNullOrEmpty(user.FirstName) ? existedUser.FirstName : user.FirstName;
            existedUser.LastName = string.IsNullOrEmpty(user.LastName) ? existedUser.LastName : user.LastName;
            _userDal.Update(existedUser);
            return new SuccessDataResult<User>(Messages.UserUpdated);
        }
    }
}


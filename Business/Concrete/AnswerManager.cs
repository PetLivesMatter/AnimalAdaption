﻿using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;
using Core.Utilities.Results;
using Business.Constants;
using Entities.DTOs;

namespace Business.Concrete
{
    public class AnswerManager : IAnswerService
    {
        IAnswerDal _answerDal;

        public AnswerManager(IAnswerDal answerDal)
        {
            _answerDal = answerDal;

        }

        public IResult Add(Answer answer)
        {
            _answerDal.Add(answer);
            return new SuccessResult(Messages.AnswerAdded);
        }

        public IDataResult<Answer> Delete(Answer answer)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Answer>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Answer>>(Messages.AnswerAdded);
            }
            return new SuccessDataResult<List<Answer>>(_answerDal.GetAll(), Messages.AnswerAll);
        }

        public IDataResult<List<AnswerDetailDto>> GetAnswerDetail()
        {
            return new SuccessDataResult<List<AnswerDetailDto>>(_answerDal.GetAnswerDetail());
        }

        public IDataResult<Answer> GetById(int answerId)
        {
            return new SuccessDataResult<Answer>(_answerDal.Get(a => a.AnswerId == answerId));
        }

        public IDataResult<Answer> Update(Answer answer)
        {
            throw new NotImplementedException();
        }
    }
}
}

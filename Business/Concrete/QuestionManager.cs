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
    public class QuestionManager : IQuestionService
    {
        IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;

        }

        public IResult Add(Question question)
        {
            _questionDal.Add(question);
            return new SuccessResult();
        }

        public IDataResult<Question> Delete(Question question)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Question>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Question>>(Messages.QuestionAdded);
            }
            return new SuccessDataResult<List<Question>>(_questionDal.GetAll(), Messages.QuestionAll);
        }

        public IDataResult<List<QuestionDetailDto>> GetQuestionDetail()
        {
            return new SuccessDataResult<List<QuestionDetailDto>>(_questionDal.GetQuestionDetail());
        }

        public IDataResult<Question> GetById(int questionId)
        {
            return new SuccessDataResult<Question>(_questionDal.Get(a => a.QuestionId == questionId));
        }

        public IDataResult<Question> Update(Question question)
        {
            throw new NotImplementedException();
        }
    }
}


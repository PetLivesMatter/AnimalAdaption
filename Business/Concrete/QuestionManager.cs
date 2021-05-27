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

        public IDataResult<Question> Delete(Question Id)
        {
            _questionDal.Delete(Id);

            return new SuccessDataResult<Question>(Messages.QuestionDeleted);
        }

        public IDataResult<List<Question>> GetAll()
        {
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

        public IDataResult<Question> Update(Question question , string directoryPath)
        {
            Question existedQuestion = _questionDal.Get(a => a.QuestionId == question.QuestionId);
            existedQuestion.Content = string.IsNullOrEmpty(question.Content) ? existedQuestion.Content : question.Content;
            existedQuestion.Title = string.IsNullOrEmpty(question.Title) ? existedQuestion.Title : question.Title;

            _questionDal.Update(existedQuestion);
            return new SuccessDataResult<Question>(Messages.QuestionUpdated);
        }
    }
}


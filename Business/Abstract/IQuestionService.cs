using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IQuestionService
    {
        IDataResult<List<Question>> GetAll();
        IDataResult<List<QuestionDetailDto>> GetQuestionDetail();
        IResult Add(Question question);
        IDataResult<Question> Delete(Question question);
        IDataResult<Question> Update(Question question);
        IDataResult<Question> GetById(int questionId);
    }
}
}

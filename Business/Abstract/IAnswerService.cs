using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAnswerService
    {
        IDataResult<List<Answer>> GetAll();
        IDataResult<List<AnswerDetailDto>> GetAnswerDetail();
        IResult Add(Answer answer);
        IDataResult<Answer> Delete(Answer answer);
        IDataResult<Answer> Update(Answer answer);
        IDataResult<Answer> GetById(int answerId);
    }
}

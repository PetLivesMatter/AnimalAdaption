using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAnswerService
    {
        IDataResult<List<Answer>> GetAll();
        IDataResult<List<AnswerDetailDto>> GetAnswerDetail();
        IResult Add(Answer answer);
        IDataResult<Answer> Delete(Answer answer);
        IDataResult<Answer> GetById(int answerId);
    }
}

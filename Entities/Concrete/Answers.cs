using Entities.Abstract;

namespace Entities.Concrete
{
    public class Answers : IEntity
    {
        public int AnswersId { get; set; }
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }

    }
}

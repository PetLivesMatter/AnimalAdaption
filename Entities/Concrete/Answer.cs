using Core.Entities;

namespace Entities.Concrete
{
    public class Answer : IEntity
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }

    }
}

using Core.Entities;
using System.Transactions;


namespace Entities.Concrete
{
    public class Question : IEntity
    {
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}

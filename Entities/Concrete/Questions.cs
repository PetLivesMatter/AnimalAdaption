using System.Transactions;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Questions : IEntity
    {
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}

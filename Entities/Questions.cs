using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Questions
    {
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}

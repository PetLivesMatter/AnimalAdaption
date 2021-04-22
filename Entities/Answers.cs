using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Answers
    {
        public int AnswersId { get; set; }
        public int QuestionId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }

    }
}

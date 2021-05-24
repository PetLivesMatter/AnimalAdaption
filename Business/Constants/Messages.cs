using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AnimalAdded = "Animal Added";
        public static string AnimalNameInvalid = "Name invalid";
        public static string AnimalAll = "All them";
        internal static string AnimalTypeNameInvalid;
        internal static string AnimalTypeAdded;
        internal static string AnimalTypeAll;

        public static string AnswerAdded { get; internal set; }
        public static List<Question> QuestionAdded { get; internal set; }
        public static string QuestionAll { get; internal set; }
        public static string AnswerAll { get; internal set; }
        public static string UserAdded { get; internal set; }
        public static string UserAll { get; internal set; }
    }
}

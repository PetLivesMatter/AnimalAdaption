using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AnimalAdded = "Animal Added";
        public static string AnimalNameInvalid = "Name invalid";
        public static string AnimalAll = "All them";
        public static string AnimalTypeNameInvalid;
        public static string AnimalTypeAdded;
        public static string AnimalTypeAll;
        public static string AuthorizationDenied = "Yetkiniz yok";
        internal static string UserRegistered;
        internal static string SuccessfulLogin;
        internal static User PasswordError;
        internal static User UserNotFound;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;

        public static string AnswerAdded { get; internal set; }
        public static List<Question> QuestionAdded { get; internal set; } 
        public static string QuestionAll { get; internal set; }
        public static string AnswerAll { get; internal set; }
        public static string UserAdded { get; internal set; }
        public static string UserAll { get; internal set; }
    }
}

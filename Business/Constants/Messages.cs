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
        public static string AnimalTypeNameInvalid = "Geçersiz hayvan türü";
        public static string AnimalTypeAdded = "Tür eklendi";
        public static string AnimalTypeAll = "Tüm türler listelendi";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanıcı girişi";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string PasswordError = "Şifre hatalı";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserAlreadyExists;
        public static string AccessTokenCreated;

        public static string AnswerAdded = "Cevap eklendi";
        public static string QuestionAdded = "Soru eklendi";
        public static string QuestionAll = "Tüm sorular listelendi";
        public static string AnswerAll = "Tüm cevaplar listelendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserAll = "Tüm kullanıcılar ";
        internal static Animal AnimalUpdated;
        internal static Advertisement AdvertisementDeleted;
        internal static AnimalType AnimalTypeDeleted;
        internal static Answer AnswerDeleted;
        internal static Question QuestionUpdated;

        public static string AnimalDeleted { get; internal set; }
    }
}

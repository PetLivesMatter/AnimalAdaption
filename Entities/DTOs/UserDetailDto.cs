using System;
using System.Collections.Generic;
using System.Text;
using Core;

namespace Entities.DTOs
{
    public class UserDetailDto : IDto 
    {
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserAddress { get; set; }
        public string UserPassword { get; set; }
        public string UserMail { get; set; }
        public string UserPhone { get; set; }
    }
}

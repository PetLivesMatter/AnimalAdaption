using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class UserAccessToken
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Language { get; set; }
        public bool Status { get; set; }
        public string Image { get; set; }
        public string UserGuid { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
    }

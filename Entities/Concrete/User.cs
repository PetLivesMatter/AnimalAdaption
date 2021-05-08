using Core.Entities;

namespace Entities.Concrete
{
    public class User : IEntity
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

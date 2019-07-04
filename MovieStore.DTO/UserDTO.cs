using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.DTO
{
    public class UserDTO : IEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public System.DateTime LastLoginDate { get; set; }
        public byte RecordStatusId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public string RecordStatusName { get; set; }
        public string CreatedByName { get; set; }

        public string DisplayString { get { return "Ad Soyad: " + FirstName + " " + LastName + " Kullanıcı Adı: " + UserName; } }
    }
}

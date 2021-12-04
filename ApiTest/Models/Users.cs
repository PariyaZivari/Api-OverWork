using System;
using System.Collections.Generic;

namespace ApiTest.Models
{
    public partial class Users
    {
        public Users()
        {
            UserUnits = new HashSet<UserUnits>();
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int State { get; set; }
        public byte[] UserImage { get; set; }

        public virtual RecordStates StateNavigation { get; set; }
        public virtual ICollection<UserUnits> UserUnits { get; set; }
    }
}

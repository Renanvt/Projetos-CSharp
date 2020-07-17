using System;
using System.Collections.Generic;
using System.Text;

namespace exe04.Entities
{
    class Users
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public Users(string userName, DateTime instant)
        {
            UserName = userName;
            Instant = instant;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Users))
            {
                return false;
            }
            return obj is Users users &&
                   UserName == users.UserName;
        }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Equals.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        //Customizar comparacao de um Cliente com outro
        public override bool Equals(object obj)
        {
            if(!(obj is Client))
            {
                return false;
            }
            Client other = obj as Client;
            return Email.Equals(other.Email);
        }
        public override int GetHashCode()
        {
            return Email.GetHashCode();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace exe05
{
    class Students
    {
        public int Id { get; set; }

        public override bool Equals(object obj)
        {
            if(!(obj is Students))
            {
                return false;
            }
            return obj is Students students &&
                   Id == students.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}

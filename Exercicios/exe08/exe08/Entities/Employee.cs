using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace exe08.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return Name
                +","
                +Email
                +","
                +Salary.ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}

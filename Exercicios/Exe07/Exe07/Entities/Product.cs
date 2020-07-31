using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exe07.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        
       
        public override string ToString()
        {
            return Name ;
        }
    }
}

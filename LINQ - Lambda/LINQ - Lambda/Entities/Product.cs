using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LINQ___Lambda.Entities
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return ID
                + ", "
                + Name
                + ", " +
                Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Category.Name
                + ", "
                + Category.Tier;
                
        }
    }
}

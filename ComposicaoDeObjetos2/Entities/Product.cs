using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
namespace Entities
{
    class Product
    {   
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(){
            
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
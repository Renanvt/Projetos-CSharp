using System;
using System.Collections.Generic;
using System.Text;

namespace Hash_Igualdade.Entities
{
    class Product //Tipo referencia
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}

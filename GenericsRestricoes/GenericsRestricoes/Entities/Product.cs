using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace GenericsRestricoes.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return Name
                +", "
                + Price.ToString("f2",CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Erro de comparação: o argumento não é um Product");
            }
            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}

using _Comparison_T_.Entities;
using System;
using System.Collections.Generic;

namespace _Comparison_T_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 120.00));
            list.Add(new Product("Tablet", 450.00));

            list.Sort(); //Só funciona se o tipo da lista implementa a interface IComparable

            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }
    }
}

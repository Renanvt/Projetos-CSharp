using System;
using _Precidate_RemoveAll_.Entities;
using System.Collections.Generic;
namespace _Precidate_RemoveAll_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa que, a partir de uma lista de produtos, remova da lista somente aqueles cujo preço mínimo seja 100*/
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00)); 
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50)); 
            list.Add(new Product("HD Case", 80.90));

            /*Expressão lambida:*/
            //list.RemoveAll(p => p.Price >= 100.0); //Remove todos que tinham preço no valor de 100 ou superior
            list.RemoveAll(ProductTest);
            foreach(Product p in list)
            {
                Console.WriteLine(p); 
            }

        }
        //Função auxiliar
        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.0;
        }
    }
}

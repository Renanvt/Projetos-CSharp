using System;
using ActionDelegate.Entities;
using System.Collections.Generic;
namespace ActionDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fazer um programa que, a partir de uma lista de produtos, aumento o preço dos produtos em 10%
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));
            //Versão funcional
            //list.ForEach(UpdatePrice); //A função ForEach recebe um Action do tipo Product, ou seja tem que ser uma função que recebe um Produto e void
            //foreach(Product p in list)
            //{
              //  Console.WriteLine(p);
            //}
            //Exibe:
            /*Tv, 990,00
             Mouse, 55,00
            Tablet, 385,55
            HD Case, 88,99
             */

            /*Versão act delegate*/
            Action<Product> act = UpdatePrice; //act recebe uma referencia para a função
            list.ForEach(act);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            /*Versão act delegate (expressão lambda)*/
            Action<Product> act2 = p => { p.Price += p.Price * 0.1; };
            //act recebe um argumento p que leva em uma ação
            //No caso de uma ação precisa colocar {} para indicar que ela tem um CORPO, mas não irá retornar nada (void)
            list.ForEach(act2);
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }

            /*Versão act delegate (expressão lambda inline)*/
            list.ForEach(p => { p.Price += p.Price * 0.1; });
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}

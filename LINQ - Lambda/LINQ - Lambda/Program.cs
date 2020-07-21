using System;
using System.Linq;
using LINQ___Lambda.Entities;
using System.Collections.Generic;
namespace LINQ___Lambda
{
    class Program
    {
        //Imprimir é do tipo "T", recebe uma messagem e uma coleção de objetos do tipo "T", IEnumberable -> compátivel com o linq
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj  in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Category c1 = new Category() { ID = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { ID = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { ID = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { ID = 1, Name = "Computer", Price = 1100.0, Category = c2},
                new Product() { ID = 2, Name = "Hammer", Price = 90.0, Category = c1},
                new Product() { ID = 3, Name = "TV", Price = 1700.0, Category = c3},
                new Product() { ID = 4, Name = "Notebook", Price = 1300.0, Category = c2},
                new Product() { ID = 5, Name = "Saw", Price = 80.0, Category = c1},
                new Product() { ID = 6, Name = "Tablet", Price = 700.0, Category = c2},
                new Product() { ID = 7, Name = "Camera", Price = 700.0, Category = c3},
                new Product() { ID = 8, Name = "Printer", Price = 350.0, Category = c3},
                new Product() { ID = 9, Name = "MacBook", Price = 1800.0, Category = c2},
                new Product() { ID = 10, Name = "Sound Bar", Price = 700.0, Category = c3},
                new Product() { ID = 11, Name = "Level", Price = 70.0, Category = c1},
            };
            //DataSource -> products
           
            var r1 = products.Where(p => p.Category.Tier == 1 & p.Price < 900.0);
            Print("Mostrar Tier 1 e preços < 900:", r1);
            // Where(argumento => condiçãoresultante)
            //Predicate -> func que retorna um bool
            //Where<Product>(func<Product,bool> predicate)

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Mostrar somentos os produtos de categorias tools:", r2);
            /*Exibe:
             Hammer
             Saw
             Level
             */

            var r3 
        }
    }
}

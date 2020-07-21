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

            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name});
            //CategoryName -> Apelido para não haver ambiguidade
            //Pega os produtos cujo nome começa com a letra C
            //Objeto anônimo tem o .ToString padrão
            Print("Names começado com a letra 'C' e Objeto anônimo: ", r3);
            /*
             * Exibe:
             * { Name = Computer, Price = 1100, CategoryName = Computers }
             * { Name = Camera, Price = 700, CategoryName = Electronics }       
             */

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1, Ordenado por Preço e então ordenado por Nome: ", r4);
            /*
             * Exibe:
             8. Printer, 350.00, Electronics, 1
             7, Camera, 700.00, Electronics, 1  
             10, Sound Bar, 700.00, Electronics, 1
             6, Tablet, 700.00, Computers, 1
             1, Computer, 1100.00, Computers, 1
             4, Notebook, 1300.00, Computers, 1
             3, TV, 1700.00, Electronics, 1
             9, MacBook, 1800.00, Computers, 1
             
             Explicação: Ordena por preço, Depois quando empata os preços 700.00 -> 700.00, Ordena por nome
             */

            var r5 = r4.Skip(2).Take(4); //Pule os dois primeiroos e pegue 4 elementos
            Print("Tier 1, Ordenado por Preço e então ordenado por Nome, pule 2 elementos e pegue 4 elementos", r5);
            /*
             * Exibe:
             10, Sound Bar, 700.00, Electronics, 1
             6, Tablet, 700.00, Computers, 1
             1, Computer, 1100.00, Computers, 1
             4, Notebook, 1300.00, Computers, 1
             */

            var r6 = products.First();
            Console.WriteLine("Teste 1 - primero: " + r6); //Exibe o primeiro elemento do DataSource:
            /*
             * Exibe:
             * Teste 1 - primeiro: 1, computer, 1100.00, Computers, 1
             
             */
            //var r7 = products.Where(p => p.Price > 3000.0).First();
            //Where -> Vai Retornar vazio, pois não tem nenhum preço acima de 3000.0
           // Console.WriteLine("Teste 2 - primeiro: "+r7); //Vai dar Erro de Exceção
            
            var r8 = products.FirstOrDefault();
            Console.WriteLine("Teste 3 - Primeiro ou retorne empty " + r8); //Retorna 1, Computer, 1100.00, Computers, 1
            var r9 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("Teste 4 - Primeiro ou retorne empty" + r9); //Retorna empty {vazio}
            Console.WriteLine();

            var r10 = products.Where(p => p.ID == 3 || p.ID == 4); //Retorna uma coleção
            Print("Sem single or default:", r10);
            /*Exibe:
             3, TV, 1700.00, Electronics, 1
             4, Notebook, 1300.00, Computers, 1
             */
       
            var r11 = products.Where(p => p.ID == 3).SingleOrDefault(); //devolve 1 resultado ou retorna vazio se não encontrar
            //Só usar SingleOrDefault se tiver certeza que irá retornar ou 1, ou nenhum elemento
            Console.WriteLine("Single or Default teste1: "+ r11);
            //Retorna o objeto do tipo produt, onde ID==3
            //3, TV, 1700.00, Electronics, 1

            var r12 = products.Where(p => p.ID == 30).SingleOrDefault();
            Console.WriteLine("Single or Default teste2: " + r12);
            //Retorna vazio
        }
    }
}

using System;
using Func_Select.Entities;
using System.Collections.Generic;
using System.Linq;
//Função select pega uma coleção e transforma a coleção em outra
namespace Func_Select
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));
            List<string> result = list.Select(NameUpper).ToList();
            //Pega a lista original e aplica a cada elemento da lista a função NameUpper, Produzindo uma nova coleção, onde cada elemento dessa nova coleção
            //vai ser o resultado da função
            //.ToList() converte para List
            foreach (string s in result)
            {
                Console.WriteLine(s); //Imprime o nome dos produtos em caixa Alta
            }
            Func<Product, string> func = NameUpper; //Delegate que vai ser uma referencia pra uma função que recebe um Product e retorna um string
            List<string> result2 = list.Select(func).ToList();
            
            foreach (string s in result2)
            {
                Console.WriteLine(s); //Imprime o nome dos produtos em caixa Alta
            }
            //Versão com expressão Lambda
            Func<Product, string> func2 = p => p.Name.ToUpper();
            List<string> result3 = list.Select(func2).ToList();
            foreach (string s in result3)
            {
                Console.WriteLine(s); //Imprime o nome dos produtos em caixa Alta
            }
        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}

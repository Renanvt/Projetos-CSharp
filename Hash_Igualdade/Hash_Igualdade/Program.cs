using System;
using System.Collections.Generic;
using Hash_Igualdade.Entities;
namespace Hash_Igualdade
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();

            //Se GetHashCode e Equal NÃO estiverem implementados:
            //Tipos referência: compara as referencias do objeto
            //Tipos valor: compara os valores dos atributos

            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0); //prod tem endereço de memória diferente de a
            Console.WriteLine(a.Contains(prod));//Verdade, os conteúdos são igual.

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));// True, quando o tipo é struct vai comparar por conteúdo e não por referência
        }
    }
}

using System;
using System.Collections.Generic;
using _Generics.services;
namespace _Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generics permites que classes, interfaces e métodos possam ser parametrizados por tipo. Seus benefícios são: Reuso, type safety, performance
            //PrintService printService = new PrintService();
            PrintService printService = new PrintService();
            Console.Write("Quantas valores? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }
            printService.Print();
            Console.WriteLine("Primeiro: "+printService.First());
        }
    }
}

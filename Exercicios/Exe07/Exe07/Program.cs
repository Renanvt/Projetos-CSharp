using Exe07.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Exe07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o caminho do arquivo: ");
            string path = Console.ReadLine();
            List<Product> list = new List<Product>();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vect = sr.ReadLine().Split(',');
                        string name = vect[0];
                        double price = double.Parse(vect[1],CultureInfo.InvariantCulture);
                        list.Add(new Product()
                        {
                            Name = name,
                            Price = price
                        });
                    }
                    var average =
                           (from p in list
                            select p.Price).DefaultIfEmpty(0.0).Average();
                    Console.WriteLine("Preço médio: "+average.ToString("f2",CultureInfo.InvariantCulture));
                    var abaixoDaMedia =
                        (from p in list
                         where p.Price < average
                         select p).OrderByDescending(p => p.Name);
                    foreach(var obj in abaixoDaMedia)
                    {
                        Console.WriteLine(obj);
                    }
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("Error:");
                Console.WriteLine(e.Message);
            }
            //Product product = new Product() { }
        }
    }
}

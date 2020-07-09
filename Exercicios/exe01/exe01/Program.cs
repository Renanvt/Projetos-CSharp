using exe01.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace exe01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pegar o caminho do projeto em armazenando em new_dir
            string curDir = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            string new_folder = @"\\..\\..\\..\out";

            List<Item> list = new List<Item>();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o preco do produto: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Digite a quantidade: ");
                int qtd = int.Parse(Console.ReadLine());
           
                list.Add(new Item(nome, preco, qtd));
                Console.WriteLine("-----------------------");
            }

            Directory.CreateDirectory(curDir + new_folder);
            string path = curDir + new_folder + @"\summary.csv";
            try
            {

                using (StreamWriter sw = File.CreateText(path))
                {
                    foreach (var item in list)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Error:");
                Console.WriteLine(e.Message);
            }

        }
    }
}

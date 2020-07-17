using exe06.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace exe06
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> candidados = new Dictionary<string,int>(); 
            Console.Write("Entre com o caminho da pasta: ");
            string path = Console.ReadLine();
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string nome = line[0];
                        int votos = int.Parse(line[1]);
                        if (candidados.ContainsKey(nome))
                        {
                            candidados[nome] += votos;
                        }
                        else
                        {
                            candidados[nome] = votos;
                        }
                    }
                    foreach(KeyValuePair<string,int> item in candidados)
                    {
                        Console.WriteLine(item.Key+": "+item.Value);
                    }
                }
            }catch(IOException e)
            {
                Console.WriteLine("Error:" );
                Console.WriteLine(e.Message);
            }
        }
    }
}

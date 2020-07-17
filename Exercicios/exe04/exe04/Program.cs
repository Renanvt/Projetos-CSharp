using System;
using System.IO;
using System.Collections.Generic;
using exe04.Entities;

namespace exe04
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Users> set = new HashSet<Users>();
            Console.Write("Entre com o caminho da pasta: ");
            
            string path = Console.ReadLine();
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    Console.WriteLine("Total de usuários: ");
                    while (!sr.EndOfStream)
                    {
                        //Readline -> Le uma linha
                        string[] line = sr.ReadLine().Split(' ');
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        
                        set.Add(new Users(name, instant));
                    }
                    
                    Console.WriteLine(set.Count);
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

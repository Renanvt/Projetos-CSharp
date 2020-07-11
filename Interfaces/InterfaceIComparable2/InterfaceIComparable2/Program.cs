using InterfaceIComparable2.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace InterfaceIComparable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Jonatan-SSD\OneDrive\Documentos\GitHub\Projetos-CSharp\Interfaces\InterfaceIComparable2\InterfaceIComparable2\Entities\funcionarios.csv";
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort(); //Nao tem como eu ordenar essa lista se eu nao sei como comparar um funcionario com outro
                    //Sorte faz o uso da interface IComparable
                    foreach(Employee func in list)
                    {
                        Console.WriteLine(func);
                    }
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("Ocorreu um erro:");
                Console.WriteLine(e.Message);
            }
        }
    }
}

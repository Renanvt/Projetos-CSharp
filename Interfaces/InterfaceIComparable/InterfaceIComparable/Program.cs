using System;
using System.Collections.Generic;
using System.IO;
namespace InterfaceIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path = @"D:\Jonatan-SSD\OneDrive\Documentos\GitHub\Projetos-CSharp\Interfaces\InterfaceIComparable\InterfaceIComparable\arquivo\pessoas.txt";
                using (StreamReader sr = File.OpenText(path)) //Abre o arquivo
                {
                    List<string> list = new List<string>(); //Cria a lista

                    while (!sr.EndOfStream) //Percorre o arquivo, enquanto não for final do arquivo
                    {
                        list.Add(sr.ReadLine()); //Adiciona na lista a linha que eu ler nesse arquivo
                    }
                    //ORDENANDO A LISTA
                    list.Sort();//Pra funcionar o objeto da lista precisa implementar a interface IComparable
                    foreach(string str in list)
                    {
                        Console.WriteLine(str);
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Error: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}

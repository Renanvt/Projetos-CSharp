using System;
using System.IO;

namespace _UsingBlock_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Jonatan-SSD\OneDrive\Documentos\GitHub\Projetos-CSharp\Arquivos\_UsingBlock_\_UsingBlock_\file1.txt";
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    //Deste modo o recurso instanciado será automaticamente fechado quando terminar o bloco
                    using (StreamReader sr = new StreamReader(fs))  //cascateado os blocos
                    //Pode fazer só um bloco instanciando tudo em uma linha:
                    //using(StreamReader sr = File.OpenText(path)){...}
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }

                }
            }
            catch(IOException e){
                Console.WriteLine("Ocorreu um erro:");
                Console.WriteLine(e.Message);
            }

        }
    }
}

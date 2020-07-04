using System;
using System.IO;

namespace _StreamWriter_
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Jonatan-SSD\OneDrive\Documentos\GitHub\Projetos-CSharp\Arquivos\_StreamWriter_\_StreamWriter_\file1.txt";
            string targetPath = @"D:\Jonatan-SSD\OneDrive\Documentos\GitHub\Projetos-CSharp\Arquivos\_StreamWriter_\_StreamWriter_\file2.txt";
            try
            {
                //Lendo e salvando em file2
                //Lendo
                string[] lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    //AppendText -> Abre o arquivo pra escrita, escrevendo a partir do final do arquivo, acresçentando no final
                    foreach (string line in lines)
                    {
                        //escreve a string line no arquivo sw
                        sw.WriteLine(line.ToUpper());

                    }

                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Um erro ocorreu!");
                Console.WriteLine(e.Message);
            }
        }
    }
}

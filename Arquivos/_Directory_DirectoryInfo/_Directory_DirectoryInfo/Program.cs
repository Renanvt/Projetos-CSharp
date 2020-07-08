using System;
using System.IO;
using System.Collections.Generic;
namespace _Directory_DirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Jonatan-SSD\OneDrive\Documentos\GitHub\Projetos-CSharp\Arquivos\_Directory_DirectoryInfo\_Directory_DirectoryInfo\myfolder";
            try
            {
                //Lista todas as subpastas a partir da pasta informada
                //Directory.EnumerateDirectories(caminho,mascaradebusca,opcaodebusca);
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*",SearchOption.AllDirectories);
                //(caminho,"qualquerNomeDeArquivo.qualqerExtensao",inclur_todos_os_diretórios)
                //O Resultado vai ser uma coleção contendo os strings correspondentes da pasta
                Console.WriteLine("FOLDERS:");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }
                //Listar os arquivos a partir de uma pasta informada
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
                //CRIAR UMA PASTA
                Directory.CreateDirectory(path + @"\newfolder");
            }
            catch(IOException e)
            {
                Console.WriteLine("Error:");
                Console.WriteLine(e.Message);
            }
        }
    }
}

using System;
using System.IO;
using System.Xml;

namespace _Path_
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Jonatan-SSD\OneDrive\Documentos\GitHub\Projetos-CSharp\Arquivos\_Path_\_Path_\myfolder\file1.txt";
            Console.WriteLine("GetDirectoryName: "+ Path.GetDirectoryName(path));
            //retorna a porcao do caminho correspondente a pasta, deixando a pocao do arquivo de fora

            Console.WriteLine("DirectorySeparatorChar: "+ Path.DirectorySeparatorChar);
            //Mostra o caractere utilizado para separacao \ || /

            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            //Mostra o caractere utilizado para separar entra paths diferentes: ;

            Console.WriteLine("GetFileName: "+ Path.GetFileName(path));
            //Pega o nome do arquivo: file1.txt

            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            //Pega o nome do arquivo sem a extensao: file1

            Console.WriteLine("GetExtension: "+ Path.GetExtension(path));
            //Pega somente a extensao do arquivo

            Console.WriteLine("GetFullPath: "+ Path.GetFullPath(path));
            //Pega todo o caminho do arquivo

            Console.WriteLine("GetTempPath: "+ Path.GetTempPath());
            //Pega a pasta temporaria do sistema, na qual eu posso monitorar dados temporarios de aplicacoes
        }
    }
}

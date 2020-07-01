using System;
using System.IO;

namespace ConsoleApp1 {
    class Program {
        static void Main(string[] args) {
            string sourcePath = @"C:\Users\jonat\OneDrive\Documentos\GitHub\Projetos-CSharp\Arquivos\ConsoleApp1\ConsoleApp1\arquivos\file1.txt";
            //sourcePath-> Caminho do arquivo de origem
            //@ -> Para não apresentar duas barras no caminho de origem
            string targetPath = @"C:\Users\jonat\OneDrive\Documentos\GitHub\Projetos-CSharp\Arquivos\ConsoleApp1\ConsoleApp1\arquivos\file2.txt";
            //targetPath -> Caminho do arquivo de destino

            try {
                //Instanciando um objeto do tipo FileInfo
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath); // copia o arquivo
                string[] lines = File.ReadAllLines(sourcePath); //Le todas as linhas do meu arquivo e guarda cada linha como um elemento do meu vetor
                foreach(string line in lines) {//faz a varredura do vetor de string
                    Console.WriteLine(line);// imprime cada linha na tela
                }      
            }
            catch(IOException e){
                Console.WriteLine("Um erro ocorreu!");
                Console.WriteLine(e.Message);
            }
        }
    }
}

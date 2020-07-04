using System;
using System.IO;
namespace FileStream_e_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Jonatan-SSD\OneDrive\Documentos\GitHub\Projetos-CSharp\Arquivos\FileStream_e_StreamReader\FileStream_e_StreamReader\arquivos\file1.txt";
            //FileStream fs = null;
            StreamReader sr = null;
            try
            {
                //abre o arquivo
                //fs = new FileStream(path, FileMode.Open);//FileStream(caminho, modo_de_instanciacao)
                //sr = new StreamReader(fs);
                sr = File.OpenText(path); // O .OpenText implicitamente ja instancia o FileStream e o StreamReader encima dele
                string line = sr.ReadLine(); //Le uma linha do arquivo e armazena na variavel line
                Console.WriteLine(line);

                //Lendo todas as linhas do meu arquivo
                while (!sr.EndOfStream) //Enquanto eu não chegar no final da Stream
                {
                    line = sr.ReadLine(); //Le uma linha do arquivo
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Um erro ocorreu:");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
               // if (fs != null) fs.Close();
            }
        }
    }
}

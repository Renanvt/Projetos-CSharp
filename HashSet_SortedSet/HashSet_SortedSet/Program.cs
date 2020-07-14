using System;
using System.Collections.Generic;
namespace HashSet_SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando um conjunto vazio
            HashSet<string> set = new HashSet<string>();
            //Inserindo elementos no conjunto
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            //Testando se Notebook existe no conjunto
            Console.WriteLine(set.Contains("Notebook"));

            //Imprimindo o conjunto, percorrendo os elementos do conjunto fazendo iteracoes de forma interna
            foreach(string p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}

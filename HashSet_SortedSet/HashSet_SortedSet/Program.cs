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
            //Instanciando um SortedSet com elementos dentro dos colchetes
            SortedSet<int> a = new SortedSet<int>() { 10, 0, 2, 4, 5, 6, 8,  };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            PrintCollection(a);

            //Uniao entro conjuntos
            //obj.: manter a coerencia de tipos
            //Instanciando um novo conjunto C e ja inserindo dentro de C, todos os elementos do conjunto A
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b); //Fazendo a uniao de C com B, Inserindo dentro do conjunto C todos os elementos de B que não estejam já em C
            PrintCollection(c); //Imprime 0 2 4 5 6 7 8 9 10, mostrando os elementos ordenado por ser um SortedSet
        }

        //Funcao que imprime o conjunto de qualquer tipo 
        static void PrintCollection<T>(IEnumerable<T> collection) //A coleção que recebi como argumento é uma coleção do tipo "T", que implementa o IEnumerable
        {
            //IEnumerable -> E uma interface implementada por todas as coleções básicas do pacote System.Collections, que são padrões de projeto para percorrer coleçoes de forma padronizada
            //GetEnumerator() -> Retorna um IEnumerable pra que possa percorrer a coleção
            foreach(T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}

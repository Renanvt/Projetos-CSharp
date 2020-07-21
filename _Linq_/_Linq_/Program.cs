using System;
using System.Collections.Generic;
using System.Linq;
namespace _Linq_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Especificar o data source
            int[] numbers = new int[] { 2, 3, 4, 5 };
            //Definir a expressão de query
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10); //Gera uma nova coleção contendo somente os números pares
                //Where -> Filtra a fonte de dados
                //Select -> Coloca a função para cada elemento da coleção
            //Pega somente os elementos pares da fonte de dados, e multiplica por 10
            //Executa a query
            foreach(int x in result)
            {
                Console.WriteLine(x);
                /*Exibe:
                 20
                40*/
            }
        }
    }
}

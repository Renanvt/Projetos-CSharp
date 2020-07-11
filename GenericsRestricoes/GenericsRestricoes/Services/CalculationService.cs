using System;
using System.Collections.Generic;
using System.Text;
using GenericsRestricoes.Services;

namespace GenericsRestricoes.Services
{
    class CalculationService
    {
        public T Max<T>(List<T> list) where T : IComparable //A minha lista vai ter que ser de um tipo "T" qualquer Onde esse tipo seja IComparable
        {
            if(list.Count == 0) // Se a quantidade de elementos na minha lista ==0
            {
                throw new ArgumentException("A lista não pode estar vazia");
            }
            T max = list[0];// Primeiro elemento da lista
            for(int i =1; i< list.Count; i++)
            {
                if(list[i].CompareTo(max) > 0) //Compara o list[i] com max, verificando se list[i] é maior do que max
                {
                    max = list[i];
                }
            }
            return max; //Maior elemento da lista
        }
    }
}

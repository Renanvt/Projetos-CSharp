using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsRestricoes
{
    class CalculationService
    {
        public int Max(List<int> list) //Retorna o maior elemento da lista
        {
            if(list.Count == 0) // Se a quantidade de elementos na minha lista ==0
            {
                throw new ArgumentException("A lista não pode estar vazia");
            }
            int max = list[0];// Primeiro elemento da lista
            for(int i =1; i< list.Count; i++)
            {
                if(list[i] > max)
                {
                    max = list[i];
                }
            }
            return max; //Maior elemento da lista
        }
    }
}

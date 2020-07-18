using System;

namespace SemTransparenciaReferencial
{
    class Program
    {
        public static int globalValue = 3;
        static void Main(string[] args)
        {
            int[] vect = new int[] { 3, 4, 5 };
            ChangeOddValues(vect); //Mude os valores ímpares do vetor. Soma + 3 a cada elemento impar do meu vetor
            Console.WriteLine(string.Join(" ",vect)); //Join -> Pega cada elemento do meu vetor e juntar no string separado por espaços
            //Exibe 6 4 8. 

        }
        //Função sem transparência
        public static void ChangeOddValues(int[] numbers)
        {
            for(int i = 0; i<numbers.Length; i++) //Percorre o vetor
            {
                if(numbers[i] % 2 != 0) //Se o elemento do vetor na posição i for um número impar
                {
                    numbers[i] += globalValue; //A Função trabalha com um valor que está fora dela, Somente olhando pra função eu não sei oque ela faz totalmente
                }
            }
        }
    }
}

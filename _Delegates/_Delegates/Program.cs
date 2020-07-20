using System;

namespace _Delegates
{
    //DECLARAÇÃO DO DELEGATE
    delegate double BinaryNumericOperation(double n1, double n2);//Operação numérica binária, Só recebe 2 double como parâmetros e não casa com a função Square()
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            BinaryNumericOperation op = CalculationService.Sum; //O meu objeto op é uma referência para a função
            double result = op.Invoke(a, b); //Exibe 22, Aplicou a função sum nos operadores a e b
            //Invoke -> Invoca a função sum
            Console.WriteLine(result);

            /*Sintaxe alternativa:
              BinaryNumericOperation op = new BinaryNumericOperation(CalculationService.Sum);
             */

        }
    }
}

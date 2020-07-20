using System;

namespace MulticastDelegates
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            BinaryNumericOperation op = CalculationService.ShowSum; //Op recebe a referencia da função
            op += CalculationService.ShowMax; //Acrescenta a referencia de outra função
            op.Invoke(a, b);
            /*
             * Exibe:
             * 22 -> Resultado da função ShowSum
             * 12 -> Resultado da função ShowMax
             * Sintaxe alternativa:
             * op(a,b); -> Exibe o mesmo resultado
             */
        }
    }
}

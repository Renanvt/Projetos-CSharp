using System;

namespace _Delegates
{
    //DECLARAÇÃO DO DELEGATE
    delegate double BinaryNumericOperation(double n1, double n2);//Operação numérica binária
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            BinaryNumericOperation op = CalculationService.Sum; //O meu objeto op é uma referência para a função
            double result = op(a, b); //Exibe 22
            Console.WriteLine(result);
        }
    }
}

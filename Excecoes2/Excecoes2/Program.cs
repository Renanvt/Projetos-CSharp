using System;
using Excecoes2.Entities;
using System.Globalization;
using Excecoes2.Entities.Exceptions;

namespace Excecoes2 {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Entre com os dados da conta");
                Console.Write("Número: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Proprietário: ");
                string prop = Console.ReadLine();
                Console.Write("Saldo inicial: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Limite de saque: ");
                double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account acc = new Account(num, prop, balance, limite);
                Console.WriteLine();
                Console.Write("Entre com a quantia para saque: ");
                acc.Saque(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.WriteLine(acc);
            }catch(DomainException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}

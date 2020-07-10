using exe02.entities;
using exe02.services;
using System;
using System.Globalization;

namespace exe02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do contrado: ");
            Console.Write("Número: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com os numeros de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, value);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract, parcelas);
            

           
            Console.WriteLine("Parcelas:");
            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}

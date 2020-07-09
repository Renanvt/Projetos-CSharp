using _Interface1_.entities;
using _Interface1_.services;
using System;
using System.Globalization;

namespace _Interface1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel:");
            Console.Write("Modelo do carro: ");
            string model = Console.ReadLine();
            Console.Write("Data que voce pegou o carro (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data que voce retornou com carro (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
           
            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            Console.Write("Entre com o preco por hora: ");
            double precoHr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Entre com o preco por dia: ");
            double precoDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            RentalService rentalService = new RentalService(precoHr, precoDay);
            rentalService.ProcessInvoice(carRental);
            Console.WriteLine("Fatura: ");
            Console.WriteLine(carRental.Invoice);

        }
    }
}

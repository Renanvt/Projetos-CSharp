using ExcecoesPersonalizadas.Entities;
using System;
using ExcecoesPersonalizadas.Entities.Exceptions;
namespace ExcecoesPersonalizadas

{
    class Excecao3
    {
        static void Main(string[] args) {
            try {
                Console.Write("Número do quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                Console.Write("Data de entrada (dd/MM/yyyy): ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de saída (dd/MM/yyyy): ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation res = new Reservation(quarto, checkin, checkout);
                Console.WriteLine("Reservation: " + res);

                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva");
                Console.Write("Data de entrada (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de saída (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());
                res.UpdateDates(checkin, checkout);


                Console.WriteLine("Reservation: " + res);
            }
            catch (DomainException e) 
            {
                Console.WriteLine("Erro na reserva: "+ e.Message);
            }


        }
    }
}

using ExcecoesPersonalizadas.Entities;
using System;
namespace ExcecoesPersonalizadas
{
    class Excecao2
    {
        static void Main(string[] args)
        {
            Console.Write("Número do quarto: ");
            int quarto = int.Parse(Console.ReadLine());
            Console.Write("Data de entrada (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Data de saída (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());
            if (checkout <= checkin)
            {
                Console.WriteLine("Erro na reserva, a data de checkout tem que ser depois da data de checkin");
            }
            else
            {
                Reservation res = new Reservation(quarto, checkin, checkout);
                Console.WriteLine("Reservation: " + res);

                Console.WriteLine();
                Console.WriteLine("Entre com os dados para atualizar a reserva");
                Console.Write("Data de entrada (dd/MM/yyyy): ");
                checkin = DateTime.Parse(Console.ReadLine());
                Console.Write("Data de saída (dd/MM/yyyy): ");
                checkout = DateTime.Parse(Console.ReadLine());
                string error = res.UpdateDates(checkin, checkout);
                if(error != null) // se erro for diferente de nulo, significa que houve erro
                {
                    Console.WriteLine("Erro na reserva: " + error);
                }
                else
                {
                    Console.WriteLine("Reservation: " + res);
                }
                // Console.WriteLine(res);
            }
        }
    }
}

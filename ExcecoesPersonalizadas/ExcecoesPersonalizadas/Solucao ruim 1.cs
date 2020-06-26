/*using ExcecoesPersonalizadas.Entities;
using System;
namespace ExcecoesPersonalizadas
{
    class Excecao1
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

                DateTime now = DateTime.Now;
                if (checkin < now || checkout < now)
                {
                    Console.WriteLine("Erros nas reservas: A data reserva para atualização tem que ser datas futuras");
                }
                else if (checkout <= checkin)
                {
                    Console.WriteLine("Erro na reserva, a data de checkout tem que ser depois da data de checkin");
                }
                else
                {
                    res.UpdateDates(checkin, checkout);
                    Console.WriteLine("Reservation: " + res);
                }
                // Console.WriteLine(res);
            }
        }
    }
}
*/
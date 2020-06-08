using System;
using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;
namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            System.Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString(); 
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //O Texto Delivered precisa estar igual ao do Enum OrderStatus
            System.Console.WriteLine(os);
            System.Console.WriteLine(txt);
            //Imprime PedingPayment no formato de string
            
            //Esteriótipo na linguagem UML <<nome>>
        }
    }
}

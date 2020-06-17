using System;
using System.Globalization;
using Entities;

namespace ComposicaoDeObjetos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente:");
            System.Console.Write("Nome: ");
            string name =Console.ReadLine();
            System.Console.Write("Email: ");
            string email =Console.ReadLine();
            System.Console.Write("Data de aniversário (DD/MM/YYYY): ");
            DateTime birth =DateTime.Parse(Console.ReadLine());
            Client c1 = new Client(name,email,birth);

            Console.WriteLine("Entre com os dados:");
            System.Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Order order = new Order(DateTime.Now,status,c1);;
            System.Console.Write("Quantos items para o pedido: ");
            int N = int.Parse(Console.ReadLine());
            
            for(int i =0; i<N; i++){
                System.Console.WriteLine($"Entre com os dados do #{i+1} item:");
                System.Console.Write("Nome do produto: ");
                string prodName = Console.ReadLine();
                System.Console.Write("Preço do produto: ");
                double prodPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Product prod = new Product(prodName,prodPrice);

                System.Console.Write("Quantidade: ");
                int quant = int.Parse(Console.ReadLine());
               
                OrderItem orderItem = new OrderItem(quant,prodPrice,prod);
                
                order.AddItem(orderItem);
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Sumário do Pedido: ");
            System.Console.WriteLine(order);
        }
    }
}

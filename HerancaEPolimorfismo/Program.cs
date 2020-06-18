using System;
using System.Globalization;
using System.Collections.Generic;
using Entities;
namespace HerancaEPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de produtos: ");
            int N = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();
            for(int i=0; i<N; i++){
                System.Console.WriteLine($"Dados do #{i+1} produto:");
                System.Console.Write("Comum, usado ou importado (c/u/i)? ");
                char res = char.Parse(Console.ReadLine());
                System.Console.Write("Nome: ");
                string nome = Console.ReadLine();
                System.Console.Write("Preço: ");
                double preco = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                if(res == 'i' || res == 'I'){
                    System.Console.Write("Taxa de alfândega: ");
                    double customsFree = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(nome,preco,customsFree));
                }
                else if(res == 'u' || res == 'U'){
                    System.Console.Write("Data de fabricação(DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(nome,preco,manufactureDate));
                }else{
                    list.Add(new Product(nome,preco));
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Etiquetas de preço:");
            foreach (Product item in list)
            {
                Console.WriteLine(item.PriceTag());
            }
           
        }
    }
}

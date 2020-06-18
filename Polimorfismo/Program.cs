using System;
using System.Globalization;
using Entities;
using System.Collections.Generic;
namespace Polimorfismo

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o número de funcionários: ");
            int N = int.Parse(Console.ReadLine());
            List<Employee> list = new List<Employee>();
            for(int i=0;i<N;i++){
                System.Console.WriteLine($"Dados do funcionário #{i+1}");
                System.Console.Write("Tercerizado (s/n)? ");
                char op = char.Parse(Console.ReadLine());
                System.Console.Write("Nome: ");
                string name = Console.ReadLine();
                System.Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());
                System.Console.Write("Valor por hora: ");
                double valuePerHour = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);            
                if(op == 's' || op == 'S'){
                    System.Console.Write("Despesa adicional: ");
                    double addCh = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new OutsourceEmployee(name,hours,valuePerHour,addCh));
                }else{
                     list.Add(new Employee(name,hours,valuePerHour));
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Pagamentos: ");
            foreach (Employee obj in list)
            {
                System.Console.WriteLine(obj.Name + " - $ "+obj.Payment().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}

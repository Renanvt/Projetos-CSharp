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
            Employee func = new Employee();
            List<Employee> list = new List<Employee>();
            for(int i=0;i<N;i++){
                System.Console.WriteLine($"Dados do funcionário #{i+1}");
                System.Console.Write("Tercerizado (s/n)? ");
                string op = Console.ReadLine();
                System.Console.Write("Nome: ");
                string name = Console.ReadLine();
                System.Console.Write("Horas: ");
                int hours = int.Parse(Console.ReadLine());
                System.Console.Write("Valor por hora: ");
                double valuePerHour = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);            
                func = new Employee(name,hours,valuePerHour);
                list.Add(func);

                if(op == "s" || op == "S"){
                    System.Console.Write("Carga adicional: ");
                    double addCh = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    func = new OutsourceEmployee(name,hours,valuePerHour,addCh);
                    list.Add(func);
                }
            }
            System.Console.WriteLine("Pagamentos: ");
            foreach (Employee obj in list)
            {
                System.Console.WriteLine(obj.ToString());
            }
        }
    }
}

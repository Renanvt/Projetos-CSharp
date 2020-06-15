using System;
using System.Globalization;
using System.Collections.Generic;
using ComposicaoDeObjetos.Entities;
using ComposicaoDeObjetos.Entities.Enums;

namespace ComposicaoDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            string deptName;
            int N;
            string nome;
            double sal;
            
            Console.Write("Entre com o nome do departamento: ");
            deptName = Console.ReadLine();
            Console.WriteLine("Entre com os dados do trabalhador: ");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Salário base: ");
            sal = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
            Department dept = new Department(deptName);
            Worker worker = new Worker(nome,level,sal,dept);

            Console.Write("Quantos contratos para esse trabalhador: ");
            N = int.Parse(Console.ReadLine());

            for(int i =0; i<N;i++){
                System.Console.WriteLine($"Entre com os dados do {i+1} contrato");
                System.Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                System.Console.Write("Valor por hora: ");
                double valHr = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                System.Console.Write("Duracao (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valHr,hours);
                worker.AddContract(contract);
            }
            System.Console.Write("Entre com o mês e o ano para calcular o ganho do trabalhador (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month =int.Parse(monthAndYear.Substring(0,2));
            int year= int.Parse(monthAndYear.Substring(3));
            System.Console.WriteLine("Name: "+ worker.Name);
            System.Console.WriteLine("Department: "+ worker.Department.Name);
            System.Console.WriteLine("Income for "+monthAndYear + ": "+worker.Income(year,month).ToString("F2"),CultureInfo.InvariantCulture); 
        }
    }
}

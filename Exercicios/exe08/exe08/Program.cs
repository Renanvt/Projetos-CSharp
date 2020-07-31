using exe08.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace exe08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o caminho da pasta: ");
            string path = Console.ReadLine();
            List<Employee> list = new List<Employee>();
            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string email = fields[1];
                        double salary = double.Parse(fields[2],CultureInfo.InvariantCulture);
                        list.Add(new Employee()
                        {
                            Name = name,
                            Email = email,
                            Salary = salary
                        });
                    }
                    Console.Write("Entre com o salário: ");
                    double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.WriteLine($"Email das pessoas com o salário acima de {salario.ToString("f2",CultureInfo.InvariantCulture)}");
                    var emailProcurado =
                        (from p in list
                         where p.Salary > salario
                         orderby p.Name
                         select p.Email);
                    foreach(var obj in emailProcurado)
                    {
                        Console.WriteLine(obj);
                    }
                    var sumSalary =
                        (from p in list
                         where p.Name[0] == 'M'
                         select p).Sum(p => p.Salary);
                    Console.WriteLine("Soma de salário de pessoas cujo o nome começa com 'M': "+sumSalary.ToString("f2",CultureInfo.InvariantCulture));
                }
            }
            catch(IOException e)
            {
                Console.Write("Error: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}

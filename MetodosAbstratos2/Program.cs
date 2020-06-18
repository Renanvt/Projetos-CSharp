using System;
using System.Globalization;
using System.Collections.Generic;
using Entities;
namespace MetodosAbstratos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Entre com o número de contribuintes: ");
            int N = int.Parse(Console.ReadLine());
            List<Pessoa> list = new List<Pessoa>();
            for(int i=0;i<N; i++){
                System.Console.WriteLine($"Dados do #{i+1} contribuínte: ");
                System.Console.Write("Física ou jurídica: (f/j): ");
                char ch = char.Parse(Console.ReadLine());             
                if(ch == 'j' || ch == 'J'){          
                    System.Console.Write("Nome da organização: ");
                    string nome = Console.ReadLine();
                }else{
                    System.Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                }                
                System.Console.Write("Ganho anual: ");
                double sal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);             
                if(ch == 'j' || ch == 'J'){
                    System.Console.Write("Numero de funcionários: ");
                    double nFunc = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new PessoaJuridica(nome,sal,nFunc));
                }else{
                    System.Console.Write("Gastos com saúde: ");
                    double healthSal = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    list.Add(new PessoaFisica(nome,sal,healthSal));
                }
            }
            System.Console.WriteLine();
            System.Console.WriteLine("Quantidade de imposto: ");
            foreach (Pessoa obj in list)
            {
                System.Console.Write(obj.Nome);
                System.Console.Write(": $ ");
                System.Console.WriteLine(obj.TotImposto());
            }
        }
    }
}

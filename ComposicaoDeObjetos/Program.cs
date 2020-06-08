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
            int dep,contract;
            string nome,level;
            double sal;
            
            Console.Write("Entre com o nome do departamento");
            dep = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com os dados do trabalhador");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            level = Console.ReadLine();
            bool levelCorreto = true;
            WorkerLevel nivel;
            while(levelCorreto){
                if(level == "Junior"){
                    nivel = Enum.Parse<WorkerLevel>("JUNIOR");
                }
                else if(level == "MidLevel"){
                    nivel = Enum.Parse<WorkerLevel>("MID_LEVEL");
                }
                else if(level == "Senior"){
                    nivel = Enum.Parse<WorkerLevel>("SENIOR");
                }else{
                    System.Console.WriteLine("Digite um nível válido");
                    levelCorreto=false;
                }
            }
            Console.Write("Salário base: ");
            sal = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantos contratos para esse trabalhador: ");
            contract = int.Parse(Console.ReadLine());
            
            Worker trabalhador;
            if(level=="Junior"){
                trabalhador = new Worker(nome,WorkerLevel.JUNIOR,sal);
            }else if(level=="MidLevel"){
                trabalhador = new Worker(nome,WorkerLevel.MID_LEVEL,sal);
            }else if(level == "Senior"){
                trabalhador = new Worker(nome,WorkerLevel.SENIOR,sal);
            }

            string date="";
            double valHr=0.0;
            int dur=0;
            
            List<int> Contratos = new List<int>();
            for(int i =0; i<contract;i++){
                System.Console.WriteLine($"Entre com os dados do {i+1} contrato");
                System.Console.Write("Data (DD/MM/YYYY): ");
                date = Console.ReadLine();
                System.Console.Write("Valor por hora: ");
                valHr = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                System.Console.Write("Duracao (hours): ");
                dur = int.Parse(Console.ReadLine());
                trabalhador.addContract(dur)
            }
            
        }
    }
}

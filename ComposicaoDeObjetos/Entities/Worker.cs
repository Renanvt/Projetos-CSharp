using System;
using ComposicaoDeObjetos.Entities.Enums;
using ComposicaoDeObjetos.Entities;
using System.Collections.Generic;

namespace ComposicaoDeObjetos.Entities
{
    class Worker
    {
        public String Name { get; set; }
        public WorkerLevel Level {get;set;}
        public double BaseSalary { get; set; }
        public Department Department {get;set;} //ASSOCIAÇÃO ENTRE DUAS CLASSES DIFERENTES
        public List<HourContract> Contracts {get;set;} = new List<HourContract>();//ASSOCIAÇÃO ENTRE DUAS CLASSES DIFERENTES POR MEIO DE LISTAS, POS 1 TRABALHADOR POSSUI VÁRIOS CONTRATOS
        //New List<HourContract>() -> Estou garantindo que a minha lista não seja nula
        public Worker(){
               
        }
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
             //ATENÇÃO: Não é usual passar uma lista intanciada em um construtor de objetos
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary; // Salário base
            //PERCORRENDO A LISTA DE CONTRATOS
            foreach (HourContract contract in Contracts)
            //Para cada HourContract contrat na minha lista de Contratos
            {
                //Acrescenta na soma somente aquele contrato que é daquele ano e daquele mês
                if(contract.Date.Year == year && contract.Date.Month == month)
                sum += contract.totalValue();
            }
            return sum;
        }
    }
}
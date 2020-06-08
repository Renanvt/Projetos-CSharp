using System;
using ComposicaoDeObjetos.Entities.Enums;
using ComposicaoDeObjetos.Entities.HourContract;

namespace ComposicaoDeObjetos.Entities.Worker
{
    class Worker
    {
        private String name { get; set; }
        private WorkerLevel level {get;set;}
        private double baseSalary { get; set; }

        public Worker(string name, WorkerLevel level, double baseSalary){
            this.name = name;
            this.level = level;
            this.baseSalary = baseSalary;
        }

        
        public void addContract(HourContract contract){

        }
        public void removeContract(HourContract contract){

        }
        public double income(int year, int month){

        }
    }
}
using System;
using ComposicaoDeObjetos.Entities.Enums;
namespace ComposicaoDeObjetos.Entities
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

        
        public void addContract(DateTime contract){

        }
        public void removeContract(DateTime contract){

        }
        public double income(int year, int month){

        }
    }
}
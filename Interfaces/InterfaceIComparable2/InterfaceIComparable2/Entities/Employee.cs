using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace InterfaceIComparable2.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEmployy)
        {
            //Construtor que recebe um funcionario no formato csv
            string[] vect = csvEmployy.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);
        }
        public override string ToString()
        {
            return Name + ", " + Salary.ToString("f2", CultureInfo.InvariantCulture);
        }
        public int CompareTo(object obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Erro de comparação: o argumento não é um Employee (funcionário)");
            }
            Employee other = obj as Employee; //Downcast
            return Name.CompareTo(other.Name);
        }
    }
}

using System;

using ComposicaoDeObjetos.Entities;
namespace ComposicaoDeObjetos.Entities
{
    class Department
    {
        public string Name{get;set;}

        public Department()
        {

        }
        public Department(string name)
        {
            Name = name;
        }
    }
}
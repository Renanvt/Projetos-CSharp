using System;
using System.Collections.Generic;
using System.Text;

namespace exe06.Entities
{
    class Candidatos
    {
        public string Name { get; set; }
        public int Votos { get; set; }

        public Candidatos(string name)
        {
            Name = name;
        }

        public Candidatos(int votos)
        {
            Votos = votos;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Candidatos))
            {
                return false;
            }
            return obj is Candidatos candidatos &&
                   Name == candidatos.Name &&
                   Votos == candidatos.Votos;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Votos.GetHashCode();
        }
    }
}

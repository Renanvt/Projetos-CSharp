using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace exe01.Entities
{
    class Item
    {
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int Qtde { get; private set; }
        
        public Item()
        {

        }

        public Item(string nome, double preco, int qtde)
        {
            Nome = nome;
            Preco = preco;
            Qtde = qtde;
        }

        public double TotPreco()
        {
            Preco = Preco * Qtde;
            return Preco;
        }
        public override string ToString()
        {
           
            return $"{Nome},{TotPreco().ToString("f2",CultureInfo.InvariantCulture)}";
        }

    }
}

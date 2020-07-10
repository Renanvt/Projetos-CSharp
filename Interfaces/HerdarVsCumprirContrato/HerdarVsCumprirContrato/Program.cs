
using System;

using HerdarVsCumprirContrato.entities;
using HerdarVsCumprirContrato.Enums;
using HerdarVsCumprirContrato.model.entities;

namespace HerdarVsCumprirContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape s1 = new Circle() { Radius = 2.0, Cor = Cor.White};
            IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Cor = Cor.Black };
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}

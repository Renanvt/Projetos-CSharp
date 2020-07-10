using HerdarVsCumprirContrato.Enums;
using System;


namespace HerdarVsCumprirContrato.model.entities
{
    abstract class AbstractShape : IShape
    {
        public Cor Cor { get; set; }
        public abstract double Area();
    }
}

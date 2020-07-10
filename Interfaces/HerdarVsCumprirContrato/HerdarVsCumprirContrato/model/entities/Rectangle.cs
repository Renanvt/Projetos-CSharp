using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using HerdarVsCumprirContrato.model.entities;

namespace HerdarVsCumprirContrato.entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        
        public override double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return  "Rectangle color = "
                + Cor
                + ", width = "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("f2", CultureInfo.InvariantCulture); ;
        }
    }
}

using HerdarVsCumprirContrato.model.entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HerdarVsCumprirContrato.entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
        public override string ToString()
        {
            return "Circle color = "
                + Cor
                + ", radius = "
                + Radius.ToString("F2",CultureInfo.InvariantCulture)
                + ", area = "
                + Area().ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}

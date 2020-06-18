using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Enums;
namespace Entities{
    abstract class Shape
    {
      
        public Color Color { get; set; }
        
         public Shape()
        {

        }
        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
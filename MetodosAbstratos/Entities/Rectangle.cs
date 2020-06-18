using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Enums;
namespace Entities{
    class Rectangle : Shape
    {
      
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height,Color color): base(color)
        {
            Width = width;
            Height = height;
        }
          public Rectangle()
        {
            
        }

        public override double Area(){ //Abstract precisa de um override pra ser implementado em outra classe
            return Width * Height;
        }
        
    }
}
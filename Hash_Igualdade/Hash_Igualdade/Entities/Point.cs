using System;
using System.Collections.Generic;
using System.Text;

namespace Hash_Igualdade.Entities
{
    struct Point //Tipo valor
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
    }
}

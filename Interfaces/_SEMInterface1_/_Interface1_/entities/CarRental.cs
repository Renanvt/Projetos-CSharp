using System;
using System.Collections.Generic;
using System.Text;

namespace _Interface1_.entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        //ASOCIACÕES 0 por 1
        public Vehicle Vehicle { get; set; } 
        public Invoice Invoice { get; set; }
        public CarRental()
        {

        }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}

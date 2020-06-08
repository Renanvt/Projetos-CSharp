using System;
using System.Text;
using Enumeracoes.Entities.Enums;
namespace Enumeracoes.Entities{
    class Order{
        public int Id {get;set;}
        public DateTime Moment{get;set;}
        public OrderStatus Status { get; set; }

        public override string ToString() {
            return Id
                + ","
                + Moment
                + ", "
                + Status;
        }
    }
}
using System;
using System.Text;
using System.Collections.Generic;
using System.Globalization;
namespace Entities
{
    class Order
    {
        public DateTime Moment{get;set;}
        public OrderStatus Status { get; set; }

        public void AddItem(OrderItem item){

        }
        public void RemoveItem(OrderItem item){

        }
        public double Total(){

        }
    }
}
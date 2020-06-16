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
        public Client Client {get;set;}
    
        public List<OrderItem> Items{get;set;} = new List<OrderItem>();
         public Order(DateTime moment, OrderStatus status, Client client, List<Items> items)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }
        public void AddItem(OrderItem item){
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item){
            Items.Remove(item);
        }
        public double Total(){

        }
    }
}
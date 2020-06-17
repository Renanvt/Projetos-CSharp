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
        public Order(){

        }
        
         public Order(DateTime moment, OrderStatus status, Client client)
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
            double sum=0.0;
            foreach(OrderItem item in Items){
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString(){
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Momento do pedido: "+Moment);
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Cliente: "+Client);
            sb.AppendLine("Items do pedido: ");
            foreach(OrderItem obj in Items){
               sb.AppendLine(obj.ToString());
            }
            sb.AppendLine("Preço total: "+Total().ToString("F2",CultureInfo.InvariantCulture));

            return sb.ToString();
        } 
    }
}
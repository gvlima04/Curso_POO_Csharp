using System;
using System.Collections.Generic;
using System.Text;
using Sld123.Entities;
using Sld123.Entities.Enums;

namespace Sld123.Entities
{
    class Order
    {
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> List { get; set; } = new List<OrderItem>();

        public Order(OrderStatus status, Client client)
        {
            Date = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) { List.Add(item); }
        public void RemoveItem(OrderItem item) { List.Remove(item); }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in List)
            {
                sum += item.SubTotal();
            }
            return sum;

        }

    }
}

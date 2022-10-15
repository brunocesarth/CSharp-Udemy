using System;
using System.Collections.Generic;
using System.Text;
using Codigo_062.Entities;
using Codigo_062.Entities.Enums;


namespace Codigo_062.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
    }
}

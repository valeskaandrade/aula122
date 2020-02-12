using System;
using System.Collections.Generic;
using System.Text;
using TesteEnumEComposicao.Entities;
using TesteEnumEComposicao.Entities.Enums;
using System.Globalization;

namespace TesteEnumEComposicao.Entities
{
    class Order
    {
        public DateTime Moment { get; set; } 
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double Total()
        {
            double t = 0.0;
            foreach (OrderItem item in Items)
            {
                t += item.SubTotal();
            }
            return t;
        }
        public Order() { }

        public Order(DateTime moment, OrderStatus status,Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString ("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.ToString());
            sb.AppendLine("Order items: ");

            foreach(OrderItem item in Items)
            {
                sb.Append(item.ToString ());
            }
            sb.Append("Total price: $");
            sb.AppendLine(Total().ToString ("F2",CultureInfo.InvariantCulture));
                
            return sb.ToString ();

        }
    }
}

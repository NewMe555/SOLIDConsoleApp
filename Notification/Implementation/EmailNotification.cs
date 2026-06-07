using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_Food_Delivery.Notification.Interface;
using Smart_Food_Delivery.Order.Model;

namespace Smart_Food_Delivery.Notification.Implementation
{
    public class EmailNotification : INotification
    {
        public string Name => "Email";

        public void NotificationSent(OrderModel Order)
        {
        Console.WriteLine($"{Name} sent: Your order {Order.OrderId} has been confirmed.");
        }
    }
}
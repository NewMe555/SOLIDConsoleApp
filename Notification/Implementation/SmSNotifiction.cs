using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_Food_Delivery.Notification.Interface;

namespace Smart_Food_Delivery.Notification.Implementation
{
    public class SmSNotifiction : INotification
    {
        public void NotificationSent(string OrderId)
        {
             Console.WriteLine($"SMS sent: Your order {OrderId} has been confirmed.");
        }
    }
}
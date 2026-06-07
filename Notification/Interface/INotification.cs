using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_Food_Delivery.Order.Model;

namespace Smart_Food_Delivery.Notification.Interface
{
    public interface INotification
    { 

        string Name{get;}
        public void NotificationSent(OrderModel OrderId);
    }
}
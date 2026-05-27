using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_Food_Delivery.Notification.Interface
{
    public interface INotification
    { 
        public void NotificationSent(string OrderId);
    }
}
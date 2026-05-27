using Smart_Food_Delivery.Notification.Interface;

namespace Smart_Food_Delivery.Notification.Service
{
    public class NotificationService
    {
      readonly  INotification? _notification;
      public NotificationService(INotification notification)
      {
        _notification=notification;
      }

      public void StartNotification(string OrderId)
        {
            _notification?.NotificationSent(OrderId);
        }
    }
}

using Smart_Food_Delivery.Cart.Model;
using Smart_Food_Delivery.Discount;
using Smart_Food_Delivery.Notification.Interface;
using Smart_Food_Delivery.Order.Model;
using Smart_Food_Delivery.Payments.Abstraction;
using Smart_Food_Delivery.Restaurants.Model;
namespace Smart_Food_Delivery.Shared.Helpers
{
    public static class ConsoleDisplay
    {
         public static void ShowResturant(List<RestaurantModel> _restaurants)
        {
             Console.WriteLine("RESTURANT AVAILABLE ARE \n");
            foreach(var res in _restaurants)
            {
                Console.WriteLine($"{res.Id}. {res.ResturantName}");
            }
        }

        public static void ShowMenuOfResturant(RestaurantModel restaurant)
        { 
           int count=1;
             Console.WriteLine();
             Console.WriteLine($"Menu - {restaurant.ResturantName}");
              Console.WriteLine(
              new string('-',50)
              );
           foreach(var res in restaurant.Menu)
            {
               
               Console.WriteLine(
             $"{count,-5} {res.Name,-20} Rs.{res.Price,-10} {res.IsVegetarian}");
       
        
         count++;
            }
    }
        public static void showCart(CartModel cart,decimal subtotal)
        {
        Console.WriteLine();
        Console.WriteLine("===== Cart Summary =====");
        foreach (var item in cart.cartItems)
        {
            Console.WriteLine($"{item.menu.Name,-20} x {item.Quantity,-3} Rs.{item.SubTotal:0.00}");
        }

        Console.WriteLine($"Subtotal:Rs.{subtotal:0.00}");
        Console.WriteLine();
        }
       public static void ShowDiscountOptions(Dictionary<int, IDiscount> discounts)
       {
        Console.WriteLine("Select Discount:");
        foreach (var choice in discounts)
        {
            Console.WriteLine($"{choice.Key}. {choice.Value.Name}");
        }
      }

      public static void ShowPaymentOptions(Dictionary<int, PaymentTypes> paymethod)
        {
            System.Console.WriteLine("Select Payment Method");
            foreach(var choice in paymethod)
            {
                System.Console.WriteLine($"{choice.Key}.{choice.Value.Name}");
            }
        }
          public static void ShowOrder(OrderModel order)
          {
            Console.WriteLine();
            Console.WriteLine("===== Order Confirmation =====");
            Console.WriteLine($"Order ID:     {order.OrderId}");
            Console.WriteLine($"Restaurant:   {order.Resturant}");
           foreach (var item in order.cartItems)
           {
            Console.WriteLine($"{item.Name,-20} x {item.Quantity}");
           }

        Console.WriteLine($"Total Paid:   Rs.{order.TotalPaid:0.00}");
        Console.WriteLine($"Payment Mode: {order.PaymentMode}");
        Console.WriteLine($"Status:       {order.Status}");
        Console.WriteLine();
    }

        public static void ShowNotificationOptions(Dictionary<int, INotification> notificationChannels)
    {
        Console.WriteLine("Select Confirmation Channel:");
        foreach (var choice in notificationChannels)
        {
            Console.WriteLine($"{choice.Key}. {choice.Value.Name}");
        }
    }
}}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_Food_Delivery.Cart.Model;
using Smart_Food_Delivery.Order.Interface;
using Smart_Food_Delivery.Order.Model;
using Smart_Food_Delivery.Resturants.Model;

namespace Smart_Food_Delivery.Order.Service
{
    public class OrderService:IOrder
    {
       readonly IorderIdGenerator _orderIdgenerator;
        public OrderService(IorderIdGenerator orderIdgenerator)
        {
           _orderIdgenerator=orderIdgenerator;
        }
public void OrderSumaary(OrderModel order)
        {
             Console.WriteLine(
                "\n===== Order Confirmation ====="
            );
            Console.WriteLine($"Order ID {order.OrderId}");
        Console.WriteLine($"Restaurant  {order.Resturant.ResturantName}");
        Console.WriteLine($"Total Paid  {order.TotalPaid}");
         foreach (var item in order.cartItems)
         {
            Console.WriteLine($"{item.menu.Name} X {item.Quantity}");
         }
          Console.WriteLine($"Payment Mode {order.PaymentMode}");
           Console.WriteLine($"Status {order.Status}");
           }

        public OrderModel StartOrder(RestaurantModel resturant, List<CartItem> cartItems, decimal totalamount, string paymentMode)
        {
           OrderModel order=new()
           {
            OrderId=_orderIdgenerator.GenerateOrderID(),
             PaymentMode=paymentMode,
             Resturant=resturant,
             TotalPaid=totalamount,
             cartItems=cartItems,
             Status="Confirmed" 
           };
           return order;
        }
    }
}
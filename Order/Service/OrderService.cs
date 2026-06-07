
using Smart_Food_Delivery.Cart.Model;
using Smart_Food_Delivery.Order.Interface;
using Smart_Food_Delivery.Order.Model;
using Smart_Food_Delivery.Restaurants.Model;
using Smart_Food_Delivery.Shared;


namespace Smart_Food_Delivery.Order.Service
{
    public class OrderService:IorderIdGenerator
    {
       readonly IorderIdGenerator _orderIdgenerator;
        public OrderService(IorderIdGenerator orderIdgenerator)
        {
           _orderIdgenerator=orderIdgenerator;
        }


        public OrderModel CreateOrder(RestaurantModel resturant, CartModel cart, decimal finalAmount, string paymentMode)
        {
          var items=cart.cartItems.Select(items=>new OrderItem
          {
               Name = items.menu.Name,
                UnitPrice = items.menu.Price,
                Quantity = items.Quantity  
            }).ToList();

            return new OrderModel
            {
                 OrderId =_orderIdgenerator.GenerateOrderID(),
            Resturant = resturant.ResturantName,
            cartItems = items,
            TotalPaid = finalAmount,
            PaymentMode = paymentMode,
            Status = OrderStatus.Confirmed
            };
          
        }

        public string GenerateOrderID()
        {
            throw new NotImplementedException();
        }
    }
}
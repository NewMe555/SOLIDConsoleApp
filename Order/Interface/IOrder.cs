using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_Food_Delivery.Cart.Model;
using Smart_Food_Delivery.Order.Model;
using Smart_Food_Delivery.Payment.Abstraction;
using Smart_Food_Delivery.Resturants.Model;

namespace Smart_Food_Delivery.Order.Interface
{
    public interface IOrder
    {
        public OrderModel StartOrder(RestaurantModel resturant,List<CartItem> cartItems,decimal totalamount,string paymentMode);
        public void OrderSumaary(OrderModel order);
    }
}
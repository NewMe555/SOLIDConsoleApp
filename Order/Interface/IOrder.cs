
using Smart_Food_Delivery.Cart.Model;
using Smart_Food_Delivery.Order.Model;
using Smart_Food_Delivery.Restaurants.Model;


namespace Smart_Food_Delivery.Order.Interface
{
    public interface IOrder
    {
        public OrderModel StartOrder(RestaurantModel resturant,List<CartItem> cartItems,decimal totalamount,string paymentMode);
        public void OrderSumaary(OrderModel order);
    }
}
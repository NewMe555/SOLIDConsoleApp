
using Smart_Food_Delivery.Cart.Model;
using Smart_Food_Delivery.Restaurants.Model;
using Smart_Food_Delivery.Shared;


namespace Smart_Food_Delivery.Order.Model
{
    public class OrderModel
    {
        public string? OrderId { get; set; }
        public string? Resturant { get; set; }
        public List<OrderItem>? cartItems {get;set;}
        public string? PaymentMode{get;set;}
        public decimal TotalPaid { get; set; }
        public OrderStatus? Status { get; set; }
    }
}
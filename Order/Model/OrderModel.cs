
using Smart_Food_Delivery.Cart.Model;
using Smart_Food_Delivery.Resturants.Model;

namespace Smart_Food_Delivery.Order.Model
{
    public class OrderModel
    {
        public string? OrderId { get; set; }
        public RestaurantModel? Resturant { get; set; }
        public List<CartItem>? cartItems {get;set;}
        public string? PaymentMode{get;set;}
        public decimal TotalPaid { get; set; }
        public string? Status { get; set; }
    }
}
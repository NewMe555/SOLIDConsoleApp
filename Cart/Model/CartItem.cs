using Smart_Food_Delivery.Restaurants.Model;

namespace Smart_Food_Delivery.Cart.Model
{
    public class CartItem
    {
         public int Id { get; set; }
        public  MenuItem menu { get; set; }=null!;
        public decimal SubTotal { get; set; }
         public int Quantity { get; set; }

    }
}
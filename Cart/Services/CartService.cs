

using System.Security.Cryptography.X509Certificates;
using Smart_Food_Delivery.Cart.Model;
using Smart_Food_Delivery.Restaurants.Model;

namespace Smart_Food_Delivery.Cart.Service
{
    public class CartService
    {
        public bool AddToCart(CartModel cart,MenuItem menuitem,int quantity)
        {
            if (quantity <= 0)
            {
                return false;
            }
            var existingItem=cart.cartItems.FirstOrDefault(x=>x.menu.Id==menuitem.Id);
            if(existingItem is not null)
            {
                existingItem.Quantity+=quantity;
                existingItem.SubTotal = existingItem.Quantity * existingItem.menu.Price; // This should be correct
                return true;
            }
            cart.cartItems.Add(
                new CartItem
                {
                    menu=menuitem,
                    Quantity=quantity,
                    SubTotal = menuitem.Price * quantity 
                });
                return true;
            
         
        }
 
        public decimal calculateTotal(CartModel cart)=>cart.cartItems.Sum(x=>x.SubTotal);
       
    }
}
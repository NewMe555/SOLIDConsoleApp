

using Smart_Food_Delivery.Cart.Model;

namespace Smart_Food_Delivery.Cart.Service
{
    public class CartService
    {
        readonly List<CartItem> _cartItem=new();
      
        public CartService(CartModel cart,List<CartItem> cartItems)
        {
            _cartItem=cartItems;
     
        }
        public void AddToCart(CartItem cartItem)
        { 
            _cartItem.Add(cartItem);
         
        }
        public void RemoveFromCart(CartItem cartItem)
        {
            _cartItem.Remove(cartItem);
            
        }
        public decimal showCart()
        {
           
            if (_cartItem.Count == 0)
            {
                 Console.WriteLine("Restaurant Not Found");
                 return 0;
            }
            
            int count =1;
            decimal grandTotal=0;
            
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"{"#",-3} {"Item",-20} {"Qty",-5} {"Subtotal",-10}");
            Console.WriteLine(new string('-', 50));
           foreach (var item in _cartItem)
            {
                Console.WriteLine($"{count,-3} {item.menu.Name,-20} X {item.Quantity,-5} Rs.{item.SubTotal,-10}");
                grandTotal += item.SubTotal;
                count++;
            }
            
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"{"Total:",-30} Rs.{grandTotal}");
            Console.WriteLine(new string('-', 50));
            
            return grandTotal;
        }
        public CartItem? GetCartItemById(int id)
        {
            return _cartItem.FirstOrDefault(x=>x.Id==id);
        }
        public decimal calculateTotal(CartItem cartItem)
        {
           return cartItem.SubTotal=cartItem.menu.Price * cartItem.Quantity;
        }
       
    }
}
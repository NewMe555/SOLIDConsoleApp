using Smart_Food_Delivery.Restaurants.Services;
using Smart_Food_Delivery.Shared.Enums;
using Smart_Food_Delivery.Discount.Implementation;
using Smart_Food_Delivery.Discount.Service;
using Smart_Food_Delivery.Payment.PaymentService;
using Smart_Food_Delivery.Payment.Abstraction;
using Smart_Food_Delivery.Payment.Implementation;
using Smart_Food_Delivery.Payments.Implementation;
using Smart_Food_Delivery.Restaurants.Model;
using Smart_Food_Delivery.Discount;
using Smart_Food_Delivery.Cart.Model;
using Smart_Food_Delivery.Cart.Service;
using Smart_Food_Delivery.Order.Interface;
using Smart_Food_Delivery.Order.Implementation;
using Smart_Food_Delivery.Order.Service;
using Smart_Food_Delivery.Order.Model;
using Smart_Food_Delivery.Notification.Interface;
using Smart_Food_Delivery.Notification.Service;
using Smart_Food_Delivery.Notification.Implementation;
using Smart_Food_Delivery.Shared.Helpers;
namespace Smart_Food_Delivery
{
    public class Program
    {
        public static void Main(String[] arg)
        {

     
        RestaurantService restaurantService=new RestaurantService();
       CartModel cart=new CartModel();

        Console.WriteLine("===== Smart Food Delivery System =====\n");
        ConsoleDisplay.ShowResturant(restaurantService.GetRestaurants());
        RestaurantModel selectedResturant;
        while(true)
            {
                var restaurantId=ConsoleInput.ReadNumber("Select resturant:");
            var restaurant=restaurantService.GetResuturantById(restaurantId);
             if(restaurant is not null)
                {
                    selectedResturant=restaurant;
                    break;
                }
                System.Console.WriteLine("Invalid restaurant selection.Please try again");
            }
       ConsoleDisplay.ShowMenuOfResturant(selectedResturant);
         MenuService menuService=new MenuService(selectedResturant.Menu);
         CartService cartService=new CartService(cart,cart.cartItems);
       
       bool AddMore=true;
            while (AddMore)
            {
                  Console.WriteLine("\nSelect item: ");
                  int Id=Convert.ToInt32(Console.ReadLine());
                  MenuItem? selectedmenu=menuService.ShowMenuById(Id);
                    if (selectedmenu == null)
                    {
                      Console.WriteLine("Invalid item selection!");
                      continue;
                    }

                  Console.WriteLine("Enter Quantity :");
                  int quantity=Convert.ToInt32(Console.ReadLine());

                  CartItem cartItem=new CartItem
                  {
                    Id=selectedmenu.Id,
                    menu=selectedmenu,
                    Quantity=quantity
                  };
                cartService.calculateTotal(cartItem);
                  cartService.AddToCart(cartItem);
       
                Console.WriteLine("\nItem added to cart.\n");
                Console.WriteLine("Do you want to add more items? (y/n): ");
                string ans = Console.ReadLine().ToLower();
                AddMore = (ans == "y");
         
            }
      Console.WriteLine("\n===== Cart Summary =====\n");
     decimal grandTotal =cartService.showCart();
      System.Console.WriteLine(@"Select Discount:
      1. No Discount 
      2.Flat Rs 50 Discount
      3. 10% Discount");
     DiscountType discountType=(DiscountType)Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Selected Discount:{(int)(discountType)}-{discountType}");
      Dictionary <DiscountType,IDiscount> discounts= 
            new()
            {
                
                {
                    DiscountType.NoDiscount,
                    new NoDiscount()
                },
                 
                {
                    DiscountType.FlatDiscount,
                    new FlatDiscount()
                },
                 
                {
                    DiscountType.PercentageDiscount,
                    new PercentageDiscount()
                }
            };
            IDiscount discount=discounts[discountType];
            DiscountService discountService=new DiscountService(discount);
            decimal finalAmount=discountService.ApplyDiscount(grandTotal);
System.Console.WriteLine("Select Paymethod 1. Cash 2. UPI 3.Card");
int paymentChoice=Convert.ToInt32(Console.ReadLine());
Dictionary<int,PaymentTypes> paymentTypes = new()
{
    {1,new Cash()},
    {2,new UPI()},
    {3,new Card()}
};
PaymentTypes payment=paymentTypes[paymentChoice];
PaymentService paymentService=new PaymentService(payment);
paymentService.StartPaymethod(finalAmount);
IorderIdGenerator orderIdGenerator=new OrderIdGenerator();
OrderService orderService=new OrderService(orderIdGenerator);
OrderModel order=orderService.StartOrder(selectedResturant,cart.cartItems,finalAmount,payment.GetType().Name);
orderService.OrderSumaary(order);
INotification notification =new SmSNotifiction();
NotificationService
notificationService =
    new NotificationService(
        notification
    );
    System.Console.WriteLine("Sending notification...");
    notificationService.StartNotification(order.OrderId);
      }
    
    }
}

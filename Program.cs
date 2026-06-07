using Smart_Food_Delivery.Restaurants.Model;
using Smart_Food_Delivery.Cart.Model;
using Smart_Food_Delivery.Cart.Service;
using Smart_Food_Delivery.Shared.Helpers;
using Smart_Food_Delivery.Discount.Discount;
using Smart_Food_Delivery.Payments.Factory;
using Smart_Food_Delivery.Order.Service;
using Smart_Food_Delivery.Notification.Interface;
using Smart_Food_Delivery.Notification.Implementation;
using Smart_Food_Delivery.Order.Implementation;
namespace Smart_Food_Delivery
{
    public class Program
    {
        public static void Main(String[] arg)
        {

     
        RestaurantService restaurantService=new RestaurantService();
        CartModel cart=new CartModel();
        CartService cartService=new CartService();
var orderService = new OrderService(new OrderIdGenerator());

        //Factories
        var discountfactory=new DiscountFactory();
        var paymentFactory=new PaymentFactory();

        //App started printing output
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
            while (true)
            {
                MenuItem selectedItem;
                while (true)
                {
                    var ItemID=ConsoleInput.ReadNumber("\nSelect item: ");
                    var item=restaurantService.GetMenuItemById(selectedResturant,ItemID);
                if(item is not null)
                    {
                        selectedItem=item;
                        break; 
                    }
                    Console.WriteLine("Invalid menu item. Please try again.");
                }
                //quantity Input
                  var quantity=ConsoleInput.ReadPositiveNumber("Enter quantity: ");
                  cartService.AddToCart(cart,selectedItem,quantity);
                  System.Console.WriteLine("Item Added to cart.");
                if(!ConsoleInput.ReadYesNo("Do you want to add more items? (y/n):"))
                {
                    break;
                }
            }
                //showcart item
                  var subtotal=cartService.calculateTotal(cart);
                  ConsoleDisplay.showCart(cart,subtotal);
         
                //Discount
                var discounts=discountfactory.CreateDiscountOptions();
                ConsoleDisplay.ShowDiscountOptions(discounts);

                var discount = ConsoleInput.ReadChoice("Choice: ", discounts, "Invalid discount selection");
                var discountAmount=discount.GetDiscount(subtotal);
                var finalAmount=Math.Max(0,subtotal-discountAmount);//negative digit can be avoided
                Console.WriteLine($"Discount Amount: Rs{discountAmount:0.00}");
                Console.WriteLine($"Final Amount: Rs{finalAmount:0.00}");
                Console.WriteLine();

                //payment 
                var paymentmethods=paymentFactory.CreatePaymentOptions();
                ConsoleDisplay.ShowPaymentOptions(paymentmethods);
                var paymethod=ConsoleInput.ReadChoice("Choice: ", paymentmethods, "Invalid payment selection");
                Console.WriteLine($"Processing {paymethod.Name} paymenthod of Rs.{finalAmount:0.00}...");
                var paymentSuccessful=paymethod.makeMethod(finalAmount);
                 if (!paymentSuccessful)
                 {
                Console.WriteLine("Payment failed.Order was not created.");
                return;
                 }
                 Console.WriteLine("Payment successful");

                 //order
                 var order=orderService.CreateOrder(selectedResturant,cart,finalAmount,paymethod.Name);
                 ConsoleDisplay.ShowOrder(order);

                 //notification

                 var notificationChannel=new Dictionary<int, INotification>
                 {
                     [1]=new SmSNotifiction(),
                     [2]=new EmailNotification()
                 };

                 ConsoleDisplay.ShowNotificationOptions(notificationChannel);
                 var notification=ConsoleInput.ReadChoice("Choice", notificationChannel,"Invalid notification selection");
               notification.NotificationSent(order);  

            // System.Console.WriteLine("Select Paymethod 1. Cash 2. UPI 3.Card");
            // int paymentChoice=Convert.ToInt32(Console.ReadLine());
            // Dictionary<int,PaymentTypes> paymentTypes = new()
            // {
            //     {1,new Cash()},
            //     {2,new UPI()},
            //     {3,new Card()}
            // };
            // PaymentTypes payment=paymentTypes[paymentChoice];
            // PaymentService paymentService=new PaymentService(payment);
            // paymentService.StartPaymethod(finalAmount);
            // IorderIdGenerator orderIdGenerator=new OrderIdGenerator();
            // OrderService orderService=new OrderService(orderIdGenerator);
            // OrderModel order=orderService.StartOrder(selectedResturant,cart.cartItems,finalAmount,payment.GetType().Name);
            // orderService.OrderSumaary(order);
            // INotification notification =new SmSNotifiction();
            // NotificationService
            // notificationService =
            //     new NotificationService(
            //         notification
            //     );
            //     System.Console.WriteLine("Sending notification...");
            //     notificationService.StartNotification(order.OrderId);
        }
    
    }
}

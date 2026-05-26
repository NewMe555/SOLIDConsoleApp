using Smart_Food_Delivery.Menu;
using Smart_Food_Delivery.Restaurants.Services;
using Smart_Food_Delivery.Resturant;
using Smart_Food_Delivery.Discount;
using Smart_Food_Delivery.Resturant.Model;
using Smart_Food_Delivery.Shared.SeedData;
using Smart_Food_Delivery.Shared.Enums;
using Smart_Food_Delivery.Discount.Implementation;
using Smart_Food_Delivery.Discount.Service;
using Smart_Food_Delivery.Payment.PaymentService.cs;
using Smart_Food_Delivery.Payment.Abstraction;
using Smart_Food_Delivery.Payment.Implementation;
using Smart_Food_Delivery.Payments.Implementation;
namespace Smart_Food_Delivery
{
    public class Program
    {
        public static void Main(String[] arg)
        {
        RestaurantSeedData resseed=new RestaurantSeedData();
        var resutrantresult=resseed.Resturantdata();
        ResturantService resturantService=new(resutrantresult);

        Cart cart=new Cart();

        Console.WriteLine("===== Smart Food Delivery System =====\n");
        resturantService.ShowResturant();

        Console.WriteLine("\nSelect Restaurant:\n");

        int resNumber=Convert.ToInt32(Console.ReadLine());

        resturantService.ShowMenuOfResturant(resNumber);

        Restaurant? selectedResturant=resturantService.GetResuturantById(resNumber);

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
Console.WriteLine($"Select Payment Method: 1. Cash 2. UPI 3. Card");
           int paymentChoice=Convert.ToInt32(Console.ReadLine());
           Dictionary<int,PaymentTypes> payments = new()
           {
               {1,new Cash()},
               {2,new UPI()},
               {3,new Card()}

           };
           PaymentTypes payment=payments[paymentChoice];
            PaymentService paymentService=new PaymentService(payment);
            paymentService.ExcutePayment(finalAmount);
      }
    
    }
}

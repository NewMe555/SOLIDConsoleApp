
using Smart_Food_Delivery.Restaurants.Model;
namespace Smart_Food_Delivery.Shared.Helpers
{
    public static class ConsoleDisplay
    {
         public static void ShowResturant(List<RestaurantModel> _restaurants)
        {
             Console.WriteLine("RESTURANT AVAILABLE ARE \n");
            foreach(var res in _restaurants)
            {
                Console.WriteLine($"{res.Id}. {res.ResturantName}");
            }
        }

        public static void ShowMenuOfResturant(RestaurantModel restaurant)
        { 
           int count=0;
          System.Console.WriteLine();
             Console.WriteLine($"Menu - {restaurant.ResturantName}");
              Console.WriteLine(
              new string('-',50)
              );
           foreach(var res in restaurant.Menu)
            {
               
               Console.WriteLine(
             $"{count,-5} {res.Name,-20} Rs.{res.Price,-10} {res.Category}");
       
        
         count++;
            }
    }}
}
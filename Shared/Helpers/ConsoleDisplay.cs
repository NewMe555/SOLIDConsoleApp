
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
    }
}
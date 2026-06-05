using Smart_Food_Delivery.Restaurants.Model;
using Smart_Food_Delivery.Shared.SeedData;

namespace Smart_Food_Delivery
{
    public class RestaurantService
    {
        public readonly List<RestaurantModel> _restaurants;
        public RestaurantService()
        {
           var seed=new RestaurantSeedData();
            _restaurants=seed.Resturantdata();
        }
        public List<RestaurantModel> GetRestaurants() => _restaurants;
        public void ShowMenuOfResturant(int resturantId)
        { 
            int count=1;
           
        RestaurantModel? resturant =GetResuturantById(resturantId);
            if (resturant == null)
            {
                 Console.WriteLine("Restaurant Not Found");
                 return;
            }
             Console.WriteLine($"Menu - {resturant.ResturantName}");
              Console.WriteLine(
              new string('-',50)
              );
           foreach(var res in resturant.Menu)
            {
               
               Console.WriteLine(
             $"{count,-5} {res.Name,-20} Rs.{res.Price,-10} {res.Category}");
       
        
         count++;
            }
        }
        public RestaurantModel? GetResuturantById(int id)
        {
            return _restaurants.FirstOrDefault(x=>x.Id==id);
        }
        
    }
}
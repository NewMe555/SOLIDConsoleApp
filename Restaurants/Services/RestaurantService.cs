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
       
        public RestaurantModel? GetResuturantById(int id)
        {
            return _restaurants.FirstOrDefault(x=>x.Id==id);
        }
         public  MenuItem? GetMenuItemById(RestaurantModel restaurant,int itemId)
        {
            
         return restaurant.Menu.FirstOrDefault(x=>x.Id==itemId);
        }

        
    }
}
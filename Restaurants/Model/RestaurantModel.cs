using Smart_Food_Delivery.Restaurants.Model;

namespace Smart_Food_Delivery.Resturants.Model
{
    public class RestaurantModel
    {
        public int Id {get;set;}
        public string? ResturantName { get; set; }
        public string? Address { get; set; }
       public List<MenuItem> Menu { get; set; }=new();
    }
}
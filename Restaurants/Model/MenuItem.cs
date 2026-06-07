using Smart_Food_Delivery.Shared;
using Smart_Food_Delivery.Shared.Enums;

namespace Smart_Food_Delivery.Restaurants.Model
{
    public class MenuItem
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public decimal Price { get; set; }
            public FoodFactory IsVegetarian { get; set; }
        
    }

   
}
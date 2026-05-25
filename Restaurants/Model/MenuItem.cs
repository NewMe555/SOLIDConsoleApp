using Smart_Food_Delivery.Shared;

namespace Smart_Food_Delivery
{
    public class MenuItem
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public FoodFactory Category { get; set; }
    }

   
}
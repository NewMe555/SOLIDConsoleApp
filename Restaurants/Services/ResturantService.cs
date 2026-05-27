using Smart_Food_Delivery.Resturants.Model;
namespace Smart_Food_Delivery
{
    public class ResturantService
    {
        public readonly List<RestaurantModel> _resturant=new();
        public ResturantService(List<RestaurantModel> resturant)
        {
            _resturant=resturant;
        }
        public void ShowResturant()
        {
             Console.WriteLine("RESTURANT AVAILABLE ARE \n");
            foreach(var res in _resturant)
            {
                Console.WriteLine($"{res.Id}. {res.ResturantName}");
            }
        }
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
            return _resturant.FirstOrDefault(x=>x.Id==id);
        }
        
    }
}
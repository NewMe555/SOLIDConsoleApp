

using Smart_Food_Delivery.Restaurants.Model;

namespace Smart_Food_Delivery.Shared.SeedData
{
    public class RestaurantSeedData
    {
        MenuItemSeedData menuData = new MenuItemSeedData();
        public List<RestaurantModel> Resturantdata(){
            return new List<RestaurantModel>{
                new RestaurantModel{
                     Id =1,
                     ResturantName="WoW MOMO",
                     Address="JP Nagar",
                     Menu =menuData.MenuWowMomo(),
                },
                new RestaurantModel{
                     Id =2,
                     ResturantName="KFC",
                     Address="KR Market",
                      Menu =menuData.MenuDataKFC(),
                }
                
            };
        } 
    }
}
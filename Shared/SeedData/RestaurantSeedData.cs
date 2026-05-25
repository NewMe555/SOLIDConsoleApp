using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_Food_Delivery.Resturant;

namespace Smart_Food_Delivery.Shared.SeedData
{
    public class RestaurantSeedData
    {
        MenuItemSeedData menuData = new MenuItemSeedData();
        public List<Restaurant> Resturantdata(){
            return new List<Restaurant>{
                new Restaurant{
                     Id =1,
                     ResturantName="WoW MOMO",
                     Address="JP Nagar",
                     Menu =menuData.MenuWowMomo(),
                },
                new Restaurant{
                     Id =2,
                     ResturantName="KFC",
                     Address="KR Market",
                      Menu =menuData.MenuDataKFC(),
                }
                
            };
        } 
    }
}
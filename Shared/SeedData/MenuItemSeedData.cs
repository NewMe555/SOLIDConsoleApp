using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Smart_Food_Delivery.Menu;


namespace Smart_Food_Delivery.Shared.SeedData
{
    public class MenuItemSeedData
    {
      public List<MenuItem> MenuDataKFC()
        {
             return new List<MenuItem>
             {
                    new MenuItem 
          {
            Id= 1,
            Name = "Allo Burger",
            Price = 230.30m,
            Category = FoodFactory.Veg
          },
          new MenuItem
          {
            Id=2,
            Name="veg Momo",
            Price=150.90m,
            Category=FoodFactory.Veg
          },
             };
        }
        public List<MenuItem> MenuWowMomo()
        {
            return new List<MenuItem>
            {
          new MenuItem 
            {
                Id = 1,
                 Name = "Egg Burger",
                 Price = 250.00m,
                Category = FoodFactory.Nonveg
            },
       
            new MenuItem
          {
            Id=2,
            Name="Pizza",
            Price=800.00m,
            Category=FoodFactory.Veg
          }
                
    };
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_Food_Delivery.Restaurants.Services
{
    public class MenuService
    {
        readonly List<MenuItem> _menuItems=new();
        public MenuService(List<MenuItem> menuItems)
        {
         _menuItems=menuItems;   
        }
       public MenuItem? ShowMenuById(int id)
        {
            
            return _menuItems.FirstOrDefault(x=>x.Id==id);
        }
    }
}
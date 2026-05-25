using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_Food_Delivery.Menu;

namespace Smart_Food_Delivery.Resturant.Model
{
    public class CartItem
    {
         public int Id { get; set; }
        public  MenuItem menu { get; set; }=null!;
        public decimal SubTotal { get; set; }
         public int Quantity { get; set; }

    }
}
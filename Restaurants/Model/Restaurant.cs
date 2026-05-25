using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Smart_Food_Delivery.Resturant
{
    public class Restaurant
    {
        public int Id {get;set;}
        public string? ResturantName { get; set; }
        public string? Address { get; set; }
       public List<MenuItem> Menu { get; set; }=new();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_Food_Delivery.Discount.Implementation
{
    public class NoDiscount : IDiscount
    {
         public string Name => "No Discount";
        public decimal GetDiscount(decimal SubTotal)
        {
            return 0;
        }
    }
}
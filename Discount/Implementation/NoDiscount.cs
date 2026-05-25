using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_Food_Delivery.Discount.Implementation
{
    public class NoDiscount : IDiscount
    {
       
        public decimal Discount(decimal SubTotal)
        {
         return 0;
        }

       
    }
}
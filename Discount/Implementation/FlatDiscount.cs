using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_Food_Delivery.Discount.Implementation
{
    public class FlatDiscount : IDiscount
    {
        public decimal Discount(decimal SubTotal)
        {
            return 50;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_Food_Delivery.Discount.Implementation
{
    public class PercentageDiscount : IDiscount
    {
        public decimal Discount(decimal SubTotal)
        {
            return SubTotal*10/100;
        }
    }
}
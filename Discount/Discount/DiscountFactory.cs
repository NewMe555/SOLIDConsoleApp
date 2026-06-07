using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_Food_Delivery.Discount.Implementation;

namespace Smart_Food_Delivery.Discount.Discount
{
    public class DiscountFactory
    {
        public Dictionary<int,IDiscount> CreateDiscountOptions()
        {
            return new Dictionary<int, IDiscount>
            {
                [1]=new NoDiscount(),
                [2]=new FlatDiscount(50m),
                [3]=new PercentageDiscount(10m)
            };
        }
    }
}
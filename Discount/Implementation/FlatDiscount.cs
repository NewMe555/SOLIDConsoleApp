using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_Food_Delivery.Discount.Implementation
{
    public class FlatDiscount : IDiscount
    { 
        private readonly decimal _amount;
         public FlatDiscount(decimal amount)
         {
        _amount = amount;
         }
           public string Name => $"Flat Rs.{_amount:0.00} Discount";

        public decimal GetDiscount(decimal SubTotal)
        {
            return 50;
        }
    }
}
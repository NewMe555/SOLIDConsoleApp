using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_Food_Delivery.Discount.Implementation
{
    public class PercentageDiscount : IDiscount
    {  private readonly decimal _percentage;

    public PercentageDiscount(decimal percentage)
    {
        _percentage = percentage;
    }

    public string Name => $"{_percentage:0.00}% Discount";

        public decimal GetDiscount(decimal SubTotal)
        {
            return Math.Round(SubTotal*-_percentage/100,2); 
        }
    }
}
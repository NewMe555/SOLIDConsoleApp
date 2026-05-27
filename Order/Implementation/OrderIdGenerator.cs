using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_Food_Delivery.Order.Interface;

namespace Smart_Food_Delivery.Order.Implementation
{
    public class OrderIdGenerator : IorderIdGenerator
    {
        public string GenerateOrderID()
        {
            return $"ORD{1000+ Random.Shared.Next(1,999)}";
        }
    }
}
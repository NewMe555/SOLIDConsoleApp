using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Smart_Food_Delivery.Order.Interface
{
    public interface IorderIdGenerator
    {
        public string GenerateOrderID();
    }
}
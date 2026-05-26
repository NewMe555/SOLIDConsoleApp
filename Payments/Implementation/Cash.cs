using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_Food_Delivery.Payment.Abstraction;

namespace Smart_Food_Delivery.Payment.Implementation
{
    public class Cash : PaymentTypes
    {
        public override void ProcessPayment(decimal grandTotal)
        {
            Console.WriteLine($"Processing Cash Payment of Rs.{grandTotal}");
    }
    }
}
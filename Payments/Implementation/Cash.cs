using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_Food_Delivery.Payments.Abstraction;
using Smart_Food_Delivery.Shared.Helpers;

namespace Smart_Food_Delivery.Payments.Implementation
{
    public class Cash : PaymentTypes
    {
        public override string Name => "Cash";
        public override bool ProcessPayment(decimal SubTotal)
        {
           return MockPaymentGateway.ProcessCashPayment(SubTotal);
        }
    }
}

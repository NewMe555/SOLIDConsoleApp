using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_Food_Delivery.Payment.Implementation;
using Smart_Food_Delivery.Payments.Abstraction;
using Smart_Food_Delivery.Payments.Implementation;

namespace Smart_Food_Delivery.Payments.Factory
{
    public class PaymentFactory
    {
       
        public Dictionary<int,PaymentTypes> CreatePaymentOptions()
        {
            return new Dictionary<int,PaymentTypes>
            {
                [1]=new Card(),
                [2]=new UPI(),
                [3]=new Cash()
            };
        }
        
    }
}
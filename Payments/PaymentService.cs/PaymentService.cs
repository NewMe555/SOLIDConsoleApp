using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Smart_Food_Delivery.Payment.Abstraction;

namespace Smart_Food_Delivery.Payment.PaymentService.cs
{
    public class PaymentService
    {
       readonly PaymentTypes _payment;
       public PaymentService(PaymentTypes payment)
       {
        _payment=payment;
       }

       public void StartPaymethod(decimal finalAmount)
        {
            _payment.makeMethod(finalAmount);
        }
    }
}
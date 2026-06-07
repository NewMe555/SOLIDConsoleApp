using Smart_Food_Delivery.Payments.Abstraction;
using Smart_Food_Delivery.Shared.Helpers;

namespace Smart_Food_Delivery.Payment.Implementation
{
    public class UPI : PaymentTypes
    {
        public override string Name => "UPI";

        public override bool ProcessPayment(decimal SubTotal)
        {
            //return true; we remove this since it alway alow to payment to be true hardcoded 
            // so we added mockpaymentGatway so it was see if amount sufficeint to get detected
             // Simulate UPI payment via mock gateway
            return MockPaymentGateway.ProcessUpiPayment(SubTotal);
        }
    }
}
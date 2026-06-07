using Smart_Food_Delivery.Payments.Abstraction;
using Smart_Food_Delivery.Shared.Helpers;


namespace Smart_Food_Delivery.Payments.Implementation
{
    public class Card : PaymentTypes
    {
        public override string Name =>"Card";

        public override bool ProcessPayment(decimal grandTotal)
        {
          
            return MockPaymentGateway.ProcessCardPayment(grandTotal);
        
        }
        
    }
}
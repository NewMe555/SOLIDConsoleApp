using Smart_Food_Delivery.Payment.Abstraction;


namespace Smart_Food_Delivery.Payments.Implementation
{
    public class Card : PaymentTypes
    {
        public override void ProcessPayment(decimal grandTotal)
        {
           Console.WriteLine($"Processing Card1 Payment of Rs.{grandTotal}");
        }
    }
}
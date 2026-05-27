using Smart_Food_Delivery.Payment.Abstraction;

namespace Smart_Food_Delivery.Payment.Implementation
{
    public class UPI : PaymentTypes
    {
        public override void ProcessPayment(decimal grandTotal)
        {
                         Console.WriteLine($"Processing UPI Payment of Rs.{grandTotal}");
        }
    }
}
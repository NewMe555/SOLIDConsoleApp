namespace Smart_Food_Delivery.Payment.Abstraction
{
    public abstract class PaymentTypes
    {
      
       public  void  PaymentMethod(decimal grandTotal)
        {
             if(grandTotal<=0)
             {
              Console.WriteLine("Payment failed");
              return;
             }
             ProcessPayment(grandTotal);
       
             Console.WriteLine("Payment successful");
       }
       public abstract void ProcessPayment(decimal grandTotal);
    }
}
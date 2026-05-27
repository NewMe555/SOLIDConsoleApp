namespace Smart_Food_Delivery.Payment.Abstraction
{
    public abstract class PaymentTypes
    {
      public void makeMethod(decimal SubTotal)
        {
            if (SubTotal <= 0)
            {
                System.Console.WriteLine("Payment Failed");
                return;
            }
            ProcessPayment(SubTotal);
            System.Console.WriteLine("Payment Sucessfull");
        }
      
      public abstract void ProcessPayment(decimal SubTotal);
    }
}
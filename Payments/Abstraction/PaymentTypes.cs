namespace Smart_Food_Delivery.Payments.Abstraction
{
    public abstract class PaymentTypes
    {
      public abstract string Name{get;}
      public bool makeMethod(decimal SubTotal)
        {
            if (SubTotal <= 0)
            {
              return false;
            }
            return ProcessPayment(SubTotal);
           
        }
      
      public abstract bool ProcessPayment(decimal SubTotal);
    }
}
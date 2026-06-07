
namespace Smart_Food_Delivery.Discount.Service
{
    public class DiscountService
    {
        readonly IDiscount _discount;
        public DiscountService(IDiscount discount)
        {
            _discount=discount;
        }

        public decimal ApplyDiscount(decimal grandTotal)
        {
            decimal discountAmount=_discount.GetDiscount(grandTotal);
            decimal finalAmount=grandTotal-discountAmount;
            if (finalAmount < 0)
            {
               Console.WriteLine("Warning: Total became negative. Setting to zero.");
              finalAmount = 0;
            }
             Console.WriteLine($"Discount Amount: Rs{discountAmount}");
            Console.WriteLine($"Final Amount: Rs{finalAmount}");
            return finalAmount;
        }
    }
}

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
            decimal discountAmount=_discount.Discount(grandTotal);
            decimal finalAmount=grandTotal-discountAmount;
             System.Console.WriteLine($"Discount Amount: Rs{discountAmount}");
            System.Console.WriteLine($"Final Amount: Rs{finalAmount}");
            return finalAmount;
        }
    }
}
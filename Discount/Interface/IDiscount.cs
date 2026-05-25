namespace Smart_Food_Delivery.Discount
{
    public interface IDiscount
    {
        decimal Discount(decimal SubTotal);
    }
}
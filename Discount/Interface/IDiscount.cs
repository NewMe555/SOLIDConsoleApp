namespace Smart_Food_Delivery.Discount
{
    public interface IDiscount
    {    string Name { get; }
        decimal GetDiscount(decimal SubTotal);
    }
}
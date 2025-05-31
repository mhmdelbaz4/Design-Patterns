namespace Simple_Factory.Strategies;
public class GoldDiscount : IDiscountStrategy
{
    public double CalculateDiscount(double totalPrice)
    {
        return totalPrice > 10000 ? totalPrice * 0.1 : 0;
    }
}
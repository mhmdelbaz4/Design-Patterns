namespace Simple_Factory.Strategies;
public class SilverDiscount : IDiscountStrategy
{
    public double CalculateDiscount(double totalPrice)
    {
        return totalPrice > 10000 ? totalPrice * 0.05 : 0;
    }
}

namespace Strategy_Pattern.Strategies;
public class NewStrategy : IDiscountStrategy
{
    public double CalculateDiscount(double totalPrice)
    {
        return 0;
    }
}

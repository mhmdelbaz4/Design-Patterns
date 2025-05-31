namespace Simple_Factory.Strategies;
public class NewStrategy : IDiscountStrategy
{
    public double CalculateDiscount(double totalPrice)
    {
        return 0;
    }
}

using Simple_Factory.Strategies;
using Simple_Factory;

namespace Simple_Factory.Factories;
public class DiscountFactory
{
    public static IDiscountStrategy GetDiscountObject(CustomerType customerType)
    {
        if (customerType == CustomerType.Silver)
            return new SilverDiscount();
        else if (customerType == CustomerType.Gold)
            return new GoldDiscount();
        else
            return new NewStrategy();

    }
}

using Payments.Abstraction;

namespace Strategy_Pattern.PaymentMethods;
public class PayPallPaymentMethod : IPaymentMethod
{
    public Payment Charge(int customerId, int amount)
    {
        double commision = amount < 10000 ? amount * 0.03 : 0;
        return new Payment()
        {
            Amount = amount + commision,
            CustomerId = customerId,
            ReferenceCode = Guid.NewGuid()
        };
    }
}

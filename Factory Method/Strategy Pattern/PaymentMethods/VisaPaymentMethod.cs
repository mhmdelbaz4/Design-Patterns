using Payments.Abstraction;

namespace Strategy_Pattern.PaymentMethods;
public class VisaPaymentMethod : IPaymentMethod
{
    public Payment Charge(int customerId, int amount)
    {
        double commision = amount < 10000 ? amount * 0.02 : amount * 0.01;
        return new Payment()
        {
            Amount = amount + commision,
            CustomerId = customerId,
            ReferenceCode = Guid.NewGuid()
        };
    }
}

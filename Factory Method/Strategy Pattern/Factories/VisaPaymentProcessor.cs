using Payments.Abstraction;
using Strategy_Pattern.PaymentMethods;

namespace Strategy_Pattern.Factories;
public class VisaPaymentProcessor : PaymentProcessor
{
    public override IPaymentMethod GetPaymentMethod()
    {
        return new VisaPaymentMethod();
    }
}

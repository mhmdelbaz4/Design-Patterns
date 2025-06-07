namespace Payments.Abstraction;

public abstract class PaymentProcessor
{
    public Payment ProcessPayment(int customerId, int amount)
    {
        IPaymentMethod paymentMethod = GetPaymentMethod();
        Payment payment = paymentMethod.Charge(customerId, amount);
        return payment;
    }

    public abstract IPaymentMethod GetPaymentMethod();
}

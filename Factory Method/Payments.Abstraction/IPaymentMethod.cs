namespace Payments.Abstraction;
public interface IPaymentMethod
{
    Payment Charge(int customerId, int amount); 
}

namespace Payments.Abstraction;
public class Payment
{
    public int CustomerId { get; set; }

    public double Amount { get; set; }

    public Guid ReferenceCode { get; set; }
}

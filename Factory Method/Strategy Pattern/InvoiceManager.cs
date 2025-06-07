using Strategy_Pattern.Strategies;

namespace Strategy_Pattern;
public class InvoiceManager
{
    public Invoice CreateInvoice(Customer customer, List<InvoiceLine> invoiceLines)
    {
        var invoice = new Invoice
        {
            Customer = customer,
            InvoiceLines = invoiceLines,
            TotalPrice = invoiceLines.Sum( line => line.UnitPrice * line.Quantity)
        };
        double discount = GetDiscountStrategyObject(customer.CustomerType).CalculateDiscount(invoice.TotalPrice);
        invoice.NetPrice = invoice.TotalPrice - discount;
        return invoice;
    }
    public IDiscountStrategy GetDiscountStrategyObject(CustomerType customerType)
    {
        if (customerType == CustomerType.Silver)
            return new SilverDiscount();
        else if (customerType == CustomerType.Gold)
            return new GoldDiscount();
        else
            return new NewStrategy();
    }
}

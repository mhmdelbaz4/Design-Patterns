using Simple_Factory.Factories;

namespace Simple_Factory;
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
        double discount = DiscountFactory.GetDiscountObject(customer.CustomerType).CalculateDiscount(invoice.TotalPrice);
        invoice.NetPrice = invoice.TotalPrice - discount;
        return invoice;
    }
}

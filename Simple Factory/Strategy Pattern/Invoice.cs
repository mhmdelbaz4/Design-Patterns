namespace Simple_Factory;
public class Invoice
{
    public Customer Customer { get; set; }
    public double TotalPrice { get; set; }
    public double NetPrice { get; set; }
    public List<InvoiceLine> InvoiceLines{ get; set; }
    public override string ToString()
    {
        return $"Total Price: {TotalPrice}, Net Price: {NetPrice}";
    }
}
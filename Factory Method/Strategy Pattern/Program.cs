using Strategy_Pattern;

IEnumerable<Customer> customers = CustomerDataReader.GetCustomers();
Console.WriteLine("----------------Customers-------------------------");
foreach(Customer customer in customers)
    Console.WriteLine(customer);
while(true)
{
    Console.Write("Enter Customer Id: ");
    int.TryParse(Console.ReadLine(),out int id);

    Console.Write("Enter Quantity: ");
    int.TryParse(Console.ReadLine(),out int qunatity);


    Console.Write("Enter Unit Price: ");
    int.TryParse(Console.ReadLine(), out int unitPrice);

    
    Customer? customer = customers.First(x => x.Id == id);
    InvoiceLine invoiceLine = new InvoiceLine()
    {
        Quantity = qunatity,
        UnitPrice = unitPrice
    };

    Invoice invoice = new InvoiceManager().CreateInvoice(customer, [invoiceLine]);
    Console.WriteLine(invoice);
}
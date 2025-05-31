namespace Simple_Factory;
public class CustomerDataReader
{
    public static IEnumerable<Customer> GetCustomers()
    {
        return new List<Customer> {
            new Customer() {Id=1 ,Name ="Ahmed Ibrahim", CustomerType = CustomerType.New },
            new Customer() {Id=2 ,Name ="Osama ALi", CustomerType = CustomerType.Silver },
            new Customer() {Id=3 ,Name ="Khalid Mounir", CustomerType = CustomerType.Gold },
            new Customer() {Id=4 ,Name ="Sayed Osama", CustomerType = CustomerType.Gold }
        };
    }
}

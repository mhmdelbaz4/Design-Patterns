namespace Strategy_Pattern;
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public CustomerType CustomerType { get; set; }

    public override string ToString()
    {
        return $"[{Id}] -> Name: {Name}, Type: {CustomerType}";
    }
}

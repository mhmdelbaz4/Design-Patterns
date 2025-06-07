namespace State.Core;
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double UnitPrice { get; set; }

    public override string ToString()
    {
        return $"[{Id}] Name: {Name}, Unit Price: {UnitPrice}";
    }
}

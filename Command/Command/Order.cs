namespace Command;
public class Order
{
    public Order()
    {
        Lines = new List<OrderLine>();
    }
    public int Id { get; set; }
    public List<OrderLine> Lines { get; set; }
    
    public void AddLine(int productId, int quantity, double unitPrice)
    {
        var line = new OrderLine
        {
            ProductId = productId,
            Qunatity = quantity,
            UnitPrice = unitPrice
        };
        Lines.Add(line);
    }
}

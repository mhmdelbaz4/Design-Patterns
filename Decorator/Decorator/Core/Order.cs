namespace Decorator.Core;
public class Order
{
    public int Id { get; set; }
    public List<OrderLine> Lines { get; set; } = new List<OrderLine>();
    public void AddLine(int itemId, int quantity, double unitPrice)
    {
        Lines.Add(new OrderLine() { Itemid = itemId, Quantity= quantity, Unitprice = unitPrice});
    }
}

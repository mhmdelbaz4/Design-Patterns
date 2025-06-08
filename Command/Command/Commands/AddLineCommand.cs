namespace Command.Commands;
public class AddLineCommand(Order order, Product product, int qunatity) : ICommand
{
    public void Invoke()
    {
        order.AddLine(product.Id, qunatity, product.UnitPrice);
    }
}

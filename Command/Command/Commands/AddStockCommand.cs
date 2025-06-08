namespace Command.Commands;
public class AddStockCommand(Product product, int qunatity) : ICommand
{
    public void Invoke()
    {
        product.AddStock(qunatity);
    }
}

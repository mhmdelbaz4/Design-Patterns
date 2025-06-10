namespace Decorator.Core;
public class OrderProcessor : IOrderProcessor
{
    public void Process(Order order)
    {
        if (order.Lines.Count == 0)
            throw new ArgumentException("Order must have at least one line.");

        Thread.Sleep(5000);
        Console.WriteLine($"Order {order.Id} processed successfully.");
    }
}

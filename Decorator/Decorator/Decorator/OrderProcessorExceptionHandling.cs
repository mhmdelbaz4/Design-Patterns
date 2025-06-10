using Decorator.Core;

namespace Decorator.Decorator;
public class OrderProcessorExceptionHandling : IOrderProcessor
{
    private readonly IOrderProcessor orderProcessor;

    public OrderProcessorExceptionHandling(IOrderProcessor orderProcessor)
    {
        this.orderProcessor = orderProcessor;
    }
    public void Process(Order order)
    {
        try
        {
            orderProcessor.Process(order);
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Error processing order {order.Id}: {ex.Message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

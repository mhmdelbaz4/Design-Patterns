using Decorator.Core;
using System.Diagnostics;

namespace Decorator.Decorator;
public class OrderProcessorProfile : IOrderProcessor
{
    private readonly IOrderProcessor orderProcessor;

    public OrderProcessorProfile(IOrderProcessor orderProcessor)
    {
        this.orderProcessor = orderProcessor;
    }
    public void Process(Order order)
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        orderProcessor.Process(order);
        stopWatch.Stop();
        Console.WriteLine($"executed in {stopWatch.ElapsedMilliseconds /1000}");
    }
}

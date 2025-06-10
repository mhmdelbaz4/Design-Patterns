using Decorator.Core;

namespace Decorator.Decorator;
public class OrderProcessorQueue : IOrderProcessor
{
    private readonly Queue<Order> orders;
    public OrderProcessorQueue(IOrderProcessor orderProcessor)
    {
        orders = new Queue<Order>();
    }
    public void Process(Order order)
    {
        orders.Enqueue(order);
        Console.WriteLine($"Order {order.Id} enqueued successfully!");
    }
}

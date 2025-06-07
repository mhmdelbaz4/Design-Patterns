namespace State.Core.Order_States;
public abstract class OrderState
{
    public Order Order { get; protected set; }
    protected OrderState(Order order)
    {
        Order = order;
    }
    public virtual void Confirm()
    {
        throw new InvalidOperationException($"Cannot change order state from {Order.State} to be cancelled.");
    }
    public virtual void Cancel()
    {
        throw new InvalidOperationException($"Cannot change order state from {Order.State} to be cancelled.");
    }
    public virtual void UnderProcessing()
    {
        throw new InvalidOperationException($"Cannot change order state from {Order.State} to be underProcessing.");
    }
    public virtual void Ship()
    {
        throw new InvalidOperationException($"Cannot change order state from {Order.State} to be Shipped.");
    }
    public virtual void Deliver()
    {
        throw new InvalidOperationException($"Cannot change order state from {Order.State} to be Delivered.");
    }
    public virtual void Return()
    {
        throw new InvalidOperationException($"Cannot change order state from {Order.State} to be Returned.");
    }
}

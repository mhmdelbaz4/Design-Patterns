namespace State.Core.Order_States;
public class ShippedOrderState : OrderState
{
    public ShippedOrderState(Order order) : base(order)
    {
        Order.State = Core.OrderState.Shipped;
    }

    public override void Deliver()
    {
        Order.StateBehavorial = new DeliveredOrderState(Order);
    }
}
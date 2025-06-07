namespace State.Core.Order_States;
public class UnderProcessingOrderState : OrderState
{
    public UnderProcessingOrderState(Order order) : base(order)
    {
        Order.State = Core.OrderState.UnderProcessing;
    }

    public override void Ship()
    {
        Order.StateBehavorial = new ShippedOrderState(Order);
    }
}

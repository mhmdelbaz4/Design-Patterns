namespace State.Core.Order_States;
public class DeliveredOrderState : OrderState
{
    public DeliveredOrderState(Order order) : base(order)
    {
        Order.State = Core.OrderState.Delivered;
    }

    public override void Return()
    {
        Order.StateBehavorial = new ReturnedOrderState(Order);
    }
}

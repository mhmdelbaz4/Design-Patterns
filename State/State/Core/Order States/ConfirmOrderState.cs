namespace State.Core.Order_States;
public class ConfirmOrderState : OrderState
{
    public ConfirmOrderState(Order order) : base(order)
    { 
        Order.State = Core.OrderState.Confirmed;
    }

    public override void Cancel()
    {
        Order.StateBehavorial = new CancelOrderState(Order);
    }

    public override void UnderProcessing()
    {
        Order.StateBehavorial = new UnderProcessingOrderState(Order);
    }
}

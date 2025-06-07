namespace State.Core.Order_States;
public class DraftOrderState : OrderState
{
    public DraftOrderState(Order order) : base(order)
    {
        Order.State = Core.OrderState.Draft;
    }

    public override void Confirm()
    {
        Order.StateBehavorial = new ConfirmOrderState(Order);
    }
}

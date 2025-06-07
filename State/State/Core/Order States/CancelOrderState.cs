namespace State.Core.Order_States;
public class CancelOrderState : OrderState
{
    public CancelOrderState(Order order) : base(order)
    {
        Order.State = Core.OrderState.Cacelled;
    }
}

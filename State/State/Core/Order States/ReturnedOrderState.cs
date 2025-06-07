namespace State.Core.Order_States;
public class ReturnedOrderState : OrderState
{
    public ReturnedOrderState(Order order) : base(order)
    {
        Order.State = Core.OrderState.Returned;
    }
}

using State.Core.Order_States;

namespace State.Core;
public class Order
{
    public Order()
    {
        StateBehavorial = new DraftOrderState(this);
    }
    public Order_States.OrderState StateBehavorial { get; set; }
    public OrderState State { get; set; }
    public List<OrderLine> Lines { get; set; } = new List<OrderLine>();

    //public void SetState(OrderState newState)
    //{
    //    if (state == OrderState.Draft && newState != OrderState.Confirmed ||
    //          state == OrderState.Confirmed && newState != OrderState.UnderProcessing && newState != OrderState.Cacelled ||
    //          state == OrderState.UnderProcessing && newState != OrderState.Shipped ||
    //          state == OrderState.Shipped && newState != OrderState.Delivered ||
    //          state == OrderState.Delivered && newState != OrderState.Returned)
    //    {
    //        throw new InvalidOperationException($"Cannot change state from {state} to {newState}");
    //    }
    //    state = newState;
    //}
}

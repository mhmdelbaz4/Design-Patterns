using Decorator.Core;
using Decorator.Decorator;


Order order1 = new Order
{
    Id = 1,
    Lines = new List<OrderLine>
    {
        new OrderLine { Itemid = 1, Quantity = 2, Unitprice = 10.0 },
        new OrderLine { Itemid = 2, Quantity = 1, Unitprice = 20.0 }
    }
};
Order order2 = new Order
{
    Id = 2,
    Lines = new List<OrderLine>
    {
        new OrderLine { Itemid = 1, Quantity = 2, Unitprice = 10.0 },
        new OrderLine { Itemid = 2, Quantity = 1, Unitprice = 20.0 }
    }
};
Order order3 = new Order
{
    Id = 3,
    Lines = new List<OrderLine>()
};

var orderProcessor = new OrderProcessor();

#region Profiling
OrderProcessorProfile orderProcessorProfile = new OrderProcessorProfile(orderProcessor);
orderProcessorProfile.Process(order1);
#endregion

#region Queuning
OrderProcessorQueue orderProcessorQueue = new OrderProcessorQueue(orderProcessor);
orderProcessorQueue.Process(order1);
orderProcessorQueue.Process(order2);
#endregion


#region Exception Handling
OrderProcessorExceptionHandling orderProcessorExceptionHandling = new(orderProcessor);
orderProcessorExceptionHandling.Process(order3);
#endregion



using State;
using State.Core;

Console.WriteLine("******************State App *************************");
Product[] products = ProductDataReader.GetProducts();

foreach (Product product in products)
    Console.WriteLine(product);

Console.WriteLine("*****************************************************");
Order order = new Order();
int exit = 1;

do
{
    Console.Write("Enter Product Id or 0 to exit:");
    string input = Console.ReadLine() ?? string.Empty;
    if (int.TryParse(input, out int productId) && productId > 0 && productId <= products.Length)
    {
        Console.Write("Enter Qunatity:");
        string quantityInput = Console.ReadLine() ?? string.Empty;
        if (int.TryParse(quantityInput, out int quantity) && quantity > 0)
        {
            order.Lines.Add(new OrderLine
            {
                ProductId = productId,
                Qunatity = quantity
            });
        }
    }
    else if (productId == 0)
    {
        exit = 0;
    }
} while (exit == 0);


while (true)
{
    Console.WriteLine("Select Action:");
    Console.WriteLine("\t1. Confirmed");
    Console.WriteLine("\t2. Cancelled");
    Console.WriteLine("\t3. Under Processing");
    Console.WriteLine("\t4. Shipped");
    Console.WriteLine("\t5. Delivered");
    Console.WriteLine("\t6. Returned");
    Console.WriteLine("\t0. Exit");
    int action = int.Parse(Console.ReadLine() ?? "0");
    
    try
    {
        //switch (action) 
        //{
        //    case 0: break;
        //    case 1: order.SetState(OrderState.Confirmed); break;
        //    case 2: order.SetState(OrderState.Cacelled); break;
        //    case 3: order.SetState(OrderState.UnderProcessing); break;
        //    case 4: order.SetState(OrderState.Shipped); break;
        //    case 5: order.SetState(OrderState.Delivered); break;
        //    case 6: order.SetState(OrderState.Returned); break;
        //}

        switch (action)
        {
            case 0: break;
            case 1: order.StateBehavorial.Confirm(); break;
            case 2: order.StateBehavorial.Cancel(); break;
            case 3: order.StateBehavorial.UnderProcessing(); break;
            case 4: order.StateBehavorial.Ship(); break;
            case 5: order.StateBehavorial.Deliver(); break;
            case 6: order.StateBehavorial.Return(); break;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Order state changed to be {order.State}");
        Console.ForegroundColor = ConsoleColor.White;
    }catch(Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(ex.Message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}

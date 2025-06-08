using Command;
using Command.Command;
using Command.Commands;

var laptop =new Product(1, "Laptop", 4000, 25);
var keyboard = new Product(2, "Keyboard", 100, 15);
var mouse = new Product(3, "Mouse", 10, 15);
var headphone = new Product(4, "Headphone", 50, 5);
Order order = new Order();

#region Without Command
//while (true)
//{
//    Console.WriteLine("****************Products*********************");
//    Console.WriteLine("\t1. Laptop");
//    Console.WriteLine("\t2. Keyboard");
//    Console.WriteLine("\t3. Mouse");
//    Console.WriteLine("\t4. Headphone");
//    Console.Write("Enter Product Id (0 to exit):");
//    int number = int.Parse(Console.ReadLine() ?? "0");
//    Product selectedProduct = null;

//    if (number == 1)
//        selectedProduct = laptop;
//    else if (number == 2)
//        selectedProduct = keyboard;
//    else if (number == 3)
//        selectedProduct = mouse;
//    else if (number == 4)
//        selectedProduct = headphone;
//    else
//    {
//        var totalPrice = order.Lines.Sum(line => line.UnitPrice * line.Qunatity);
//        var totalQuantity = order.Lines.Sum(line => line.Qunatity);
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine($"Order -> Total Qunatity: {totalQuantity}, Total Price: {totalPrice}");
//        Console.ForegroundColor = ConsoleColor.Black;
//        break;
//    }
//    order.AddLine(selectedProduct?.Id ?? 0, 1, selectedProduct?.UnitPrice ?? 0);
//    selectedProduct.AddStock(-1);
//}
#endregion

#region With Command
CommandInvoker commandInvoker = new CommandInvoker();
while (true)
{
    Console.WriteLine("****************Products*********************");
    Console.WriteLine($"\t1. Laptop -> qunatity in stock: {laptop.QuantityInStock}");
    Console.WriteLine($"\t2. Keyboard -> qunatity in stock: {keyboard.QuantityInStock}");
    Console.WriteLine($"\t3. Mouse -> qunatity in stock: {mouse.QuantityInStock}");
    Console.WriteLine($"\t4. Headphone -> qunatity in stock: {headphone.QuantityInStock}");
    Console.Write("Enter Product Id (0 to exit):");
    int number = int.Parse(Console.ReadLine() ?? "0");
    Product selectedProduct = null;

    if (number == 1)
        selectedProduct = laptop;
    else if (number == 2)
        selectedProduct = keyboard;
    else if (number == 3)
        selectedProduct = mouse;
    else if (number == 4)
        selectedProduct = headphone;
    else
    {
        commandInvoker.InvokeAll();
        var totalPrice = order.Lines.Sum(line => line.UnitPrice * line.Qunatity);
        var totalQuantity = order.Lines.Sum(line => line.Qunatity);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Order -> Total Qunatity: {totalQuantity}, Total Price: {totalPrice}");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("****************Products*********************");
        Console.WriteLine($"\t1. Laptop -> qunatity in stock: {laptop.QuantityInStock}");
        Console.WriteLine($"\t2. Keyboard -> qunatity in stock: {keyboard.QuantityInStock}");
        Console.WriteLine($"\t3. Mouse -> qunatity in stock: {mouse.QuantityInStock}");
        Console.WriteLine($"\t4. Headphone -> qunatity in stock: {headphone.QuantityInStock}");
        Console.Write("Enter Product Id (0 to exit):");
        break;
    }
    commandInvoker.AddCommand(new AddLineCommand(order, selectedProduct, 1));
    commandInvoker.AddCommand(new AddStockCommand(selectedProduct, -1));
}
#endregion
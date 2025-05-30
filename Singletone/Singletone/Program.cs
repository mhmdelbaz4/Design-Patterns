using Singletone;
#region Without Singleton
//while (true)
//{
//    Console.WriteLine("Without Singleton Pattern");
//    Console.WriteLine("Enter base Currenct");
//    string baseCurrency = Console.ReadLine() ?? "";
//    Console.WriteLine("Enter target Currenct");
//    string targetCurrency = Console.ReadLine() ?? "";
//    Console.WriteLine("Enter amount");
//    decimal amount = 0;
//    decimal.TryParse(Console.ReadLine(), out amount);
//    decimal total = new ExchangeConverter().Convert(baseCurrency, targetCurrency, amount);
//    Console.WriteLine($"Total ={total}");
//}
// drawbacks
// creating object for each transaction despite the fact that exchange rates are not changing frequently
// which consumes time to load exchange rates and memory to store them
#endregion

#region With Singleton
//while (true)
//{
//    Console.WriteLine("Without Singleton Pattern");
//    Console.WriteLine("Enter base Currenct");
//    string baseCurrency = Console.ReadLine() ?? "";
//    Console.WriteLine("Enter target Currenct");
//    string targetCurrency = Console.ReadLine() ?? "";
//    Console.WriteLine("Enter amount");
//    decimal amount = 0;
//    decimal.TryParse(Console.ReadLine(), out amount);
//    decimal total = ExchangeConverterSingletone.Istance.Convert(baseCurrency, targetCurrency, amount);
//    Console.WriteLine($"Total ={total}");
//}

// Load data only for the first time only and use it for the rest of the transactions
#endregion
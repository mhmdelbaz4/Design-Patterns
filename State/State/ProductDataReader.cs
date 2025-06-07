using State.Core;

namespace State;
public static class ProductDataReader
{
    public static Product[] GetProducts()
    {
        Product[] products = new Product[10];

        products[0] = new Product { Id = 1, Name = "Laptop", UnitPrice = 1200.50 };
        products[1] = new Product { Id = 2, Name = "Mouse", UnitPrice = 25.00 };
        products[2] = new Product { Id = 3, Name = "Keyboard", UnitPrice = 75.20 };
        products[3] = new Product { Id = 4, Name = "Monitor", UnitPrice = 300.99 };
        products[4] = new Product { Id = 5, Name = "Webcam", UnitPrice = 49.99 };
        products[5] = new Product { Id = 6, Name = "Headphones", UnitPrice = 99.00 };
        products[6] = new Product { Id = 7, Name = "USB Drive", UnitPrice = 15.75 };
        products[7] = new Product { Id = 8, Name = "External Hard Drive", UnitPrice = 150.00 };
        products[8] = new Product { Id = 9, Name = "Printer", UnitPrice = 250.45 };
        products[9] = new Product { Id = 10, Name = "Router", UnitPrice = 80.60 };

        return products;
    }
}

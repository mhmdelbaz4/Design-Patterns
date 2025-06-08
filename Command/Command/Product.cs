namespace Command;
public class Product
{
    public Product(int id, string name, double unitPrice, int quantityInStock)
    {
        Id = id;
        Name = name;
        UnitPrice = unitPrice;
        QuantityInStock = quantityInStock;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public double UnitPrice { get; set; }
    public int QuantityInStock { get; set; }

    public void AddStock(int quantity)
    {
        QuantityInStock += quantity;
    }
}

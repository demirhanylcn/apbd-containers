namespace task;

public class Product
{
    private Type ProductType;

    public double ProductMass { get; private set; }
    private string ProductName;

    public Product(double ProductMass, string ProductName, Type ProductType)
    {
        this.ProductMass = ProductMass;
        this.ProductName = ProductName;
        this.ProductType = ProductType;
    }
    
}
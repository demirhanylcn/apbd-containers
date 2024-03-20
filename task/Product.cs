namespace task;

public class Product
{
    private Type ProductType;

    public double ProductMass { get;  set; }
    private string ProductName { get; set; }

    public Product(double ProductMass, string ProductName, Type ProductType)
    {
        this.ProductMass = ProductMass;
        this.ProductName = ProductName;
        this.ProductType = ProductType;
    }
    
}
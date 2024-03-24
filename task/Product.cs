namespace task;

public class Product
{
    public Type ProductType { get; set; }

    public double ProductMass { get; set; }
    public string ProductName { get; set; }
    public double Temperature { get; set; }
    public bool IsHazardous { get; set; }

    public Product(double ProductMass, string ProductName, Type ProductType, double preferedTemperature, bool isHazardous)
    {
        this.ProductMass = ProductMass;
        this.ProductName = ProductName;
        this.ProductType = ProductType;
        Temperature = preferedTemperature;
        IsHazardous = isHazardous;
    }

    public override string ToString()
    {
        return ProductType + " " + ProductName + " " + ProductMass;
    }
}
using System.ComponentModel;

namespace task;

public class R_Container : Container
{
    private string serial;
    private Type containerType { get; set; }
    private double containerTemperature;
    public List<Product> products = new List<Product>();

    public R_Container(double height, double depth, Type ContainerType, double containerTemperature) : base(height,
        depth)
    {
        initalizeSerial(ContainerType);
        containerType = ContainerType;
        this.containerTemperature = containerTemperature;
    }

    public override void initalizeSerial(Type type)
    {
        this.serial = "KON-" + type + "-" + getSerialCount();
    }

    public override void emptyTheCargo()
    {
        products.Clear();
    }

    public override void loadTheCargo(Product product)
    {
        if (CurrentWeight + product.ProductMass > MaxWeight)
        {
            throw new OverFillException("total weight can not exceed max limit");
        }
        else if (product.ProductType != containerType)
        {
            throw new Exception("product type doesnt match with container type.");
        }
        else if (product.Temperature  > containerTemperature)
        {
            throw new Exception("the temperature of container doesnt meet with requirements ");
        }
        else
        {
            products.Add(product);
            CurrentWeight += product.ProductMass;
        }
    }

    public override string ToString()
    {
        string productsString = "";
        if (products.Count != 0)
        {
            foreach (Product each in products)
            {
                productsString += each + "\n";
            }
        }
        productsString += serial;

        return productsString;
    }
}
namespace task;

public class G_Container : Container
{
    private string serial;
    private Type containerType { get; set; }

    public G_Container(double height, double depth, Type ContainerType ) : base(height, depth)
    {
        initalizeSerial(containerType);
        containerType = ContainerType;
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
            throw new OverFillException("total weight can not exceed 100%");
        }
        else if (product.ProductType != containerType)
        {
            throw new Exception("product type doesnt match with container type.");
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
        foreach (Product each in products)
        {
            productsString += each + "\n";
        }

        productsString += serial;

        return productsString;
    }
}
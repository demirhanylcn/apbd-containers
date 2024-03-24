namespace task;

public class L_Container : Container, IHazardNotifier
{
    private string serial;
    private Type containerType { get; set; }
    private bool isHazardous { get; set; }

    public L_Container(double Height, double Depth, Type ContainerType, bool hazardous) : base(Height, Depth)
    {
        initalizeSerial(ContainerType);
        containerType = ContainerType;
        if (hazardous) isHazardous = true;
    }

    public override void initalizeSerial(Type type)
    {
        this.serial = "KON-" + type + "-" + getSerialCount();
    }

    public override void emptyTheCargo()
    {
        products.Clear();
    }

    // if the mass of product is greater than the limit throw OverFill
    public override void loadTheCargo(Product product)
    {
        if (isHazardous)
        {
            if (CurrentWeight + product.ProductMass > MaxWeight / 2)
            {
                L_notify(this, "tried to fill the container more than capacity.");
                throw new OverFillException("current type is hazardous and maxWeight can not be bigger than 50%");
            }
            else if (product.ProductType != containerType)
            {
                throw new Exception("product type doesnt match with container type.");
            }
            else if (product.IsHazardous != isHazardous)
            {
                throw new Exception("product type doesnt match with container type.");
            }
            else
            {
                products.Add(product);
                CurrentWeight += product.ProductMass;
            }
        }
        else
        {
            if (CurrentWeight + product.ProductMass > MaxWeight * 0.90)
            {
                L_notify(this, "tried to fill the container more than capacity.");
                throw new OverFillException("total weight can not exceed 90%");
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

    public void L_notify(L_Container container, string message)
    {
        Console.WriteLine(container + "\n" + message);
    }
}

public interface IHazardNotifier
{
    void L_notify(L_Container container, string message);
}
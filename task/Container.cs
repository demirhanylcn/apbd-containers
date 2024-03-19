namespace task;
using System;

public enum Type
{
    L,
    G,
    R,
}

public class Container
{
    private Type ContainerType;
    private List<Product> ListOfProducts;
    private Random RandomNumberGenerator = new Random();
    
    private string SerialNumber;
    private static int SerialCount = 0;
    private string SerialStart = "KON-";
    
    private double LimitOfContainer;
    private double MassOfCargo;
    private double TotalWeight;
    private double MassOfContainer = 200;

    private double Height;
    private double Depth;
   
    
    
    
    
    

    public Container(double Height, double Depth, Type ContainerType)
    {
        ListOfProducts = new List<Product>();
        LimitOfContainer = RandomNumberGenerator.Next(500, 1000);
        this.Height = Height;
        this.Depth = Depth;
        this.ContainerType = ContainerType;
        SerialNumber = SerialStart + ContainerType.ToString() + "-" + SerialCount++;
        this.TotalWeight += MassOfContainer;
    }


    private void emptyTheCargo()
    {
        this.ListOfProducts.Clear();
        Console.WriteLine(this + " is cleared and cleaned. Ready to use!");
    }


    private void loadTheCargo (Product product)  
    {
        try
        {
            if (this.LimitOfContainer < product.ProductMass + this.TotalWeight)
            {
                throw new OverFillException("asd");
            }
            this.ListOfProducts.Add(product);
            this.TotalWeight += product.ProductMass;
        }
        catch (OverFillException e)
        {
            Console.WriteLine(e);
        }
        
    }
    public override string ToString()
    {
        return this.SerialNumber;
    }
}
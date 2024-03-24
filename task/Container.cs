namespace task;
using System;


public abstract class Container
{
    
    public static int serialCount = 0;
    public double MaxWeight { get; protected set; }
    public double Height { get; protected set; }
    public double ContainerWeight { get; protected set; }
    public double Depth { get; protected set; }
    public double CurrentWeight { get; protected set; }
    public List<Product> products { get; set; }


    public Container(double height, double depth)
    {
        Height = height;
        Depth = depth;
        ContainerWeight = 250;
        MaxWeight = 1250;
        CurrentWeight += ContainerWeight;
    }
    public abstract void initalizeSerial(Type type);
    public abstract void emptyTheCargo();
    public abstract void loadTheCargo(Product product);
    public int getSerialCount()
    {
        return serialCount++;
    }
}
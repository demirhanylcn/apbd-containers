namespace task;
using System;

public enum Type
{
    Hazardous
}

public abstract class Container
{
    public string SerialNumber {get;}
    public static int SerialCount = 0;
    public string SerialStart = "KON-";


    public abstract void initalizeSerial();
    public abstract void emptyTheCargo();
    public abstract void loadTheCargo(Product product);
    public override string ToString()
    {
        return this.SerialNumber;
    }
}
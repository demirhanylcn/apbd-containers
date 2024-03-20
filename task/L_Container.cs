namespace task;

public class L_Container : Container, IHazardNotifier
{
    public L_Container(double Height, double Depth, Type ContainerType)
    {
        
    }
    
}

public interface IHazardNotifier
{
    public void L_notify(L_Container container, string message)
    {
        Console.WriteLine(container + message);
    }
}
namespace task;

public class OverFillException : Exception
{
    public OverFillException()
    {
        
    }
    
    public OverFillException(string message) : base(message){}
}
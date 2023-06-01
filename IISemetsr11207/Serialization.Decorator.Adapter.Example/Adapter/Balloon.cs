namespace Serialization.Decorator.Adapter.Example.Adapter;

public class Balloon : IFly
{
    public void Fly()
    {
        Console.WriteLine("Летим");
    }
}
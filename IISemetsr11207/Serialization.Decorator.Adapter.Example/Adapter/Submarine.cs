namespace Serialization.Decorator.Adapter.Example.Adapter;

public class Submarine : ISwim
{
    public void Swim()
    {
        Console.WriteLine("Плывём");
    }
}
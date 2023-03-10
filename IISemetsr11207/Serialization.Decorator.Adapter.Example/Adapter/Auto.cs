namespace Serialization.Decorator.Adapter.Example.Adapter;

public class Auto : ITransport
{
    public void Drive()
    {
        Console.WriteLine("Машина едет по дороге");
    }
}

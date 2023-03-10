
namespace Serialization.Decorator.Adapter.Example.Adapter;

public class Driver
{
    public void Travel(ITransport transport)
    {
        transport.Drive();
    }
}

namespace Serialization.Decorator.Adapter.Example.Adapter;

public class SubmarineToTransportAdapter : ITransport
{
    private Submarine _submarine;

    public SubmarineToTransportAdapter(Submarine submarine)
    {
        _submarine = submarine;
    }
    
    public void Drive()
    {
        _submarine.Swim();
    }
}
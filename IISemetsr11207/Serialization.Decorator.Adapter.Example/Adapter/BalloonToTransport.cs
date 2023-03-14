namespace Serialization.Decorator.Adapter.Example.Adapter;

public class BalloonToTransport : ITransport
{
    private Balloon _ballon;

    public BalloonToTransport(Balloon ballon)
    {
        _ballon = ballon;
    }
    public void Drive()
    {
        _ballon.Fly();
    }
}
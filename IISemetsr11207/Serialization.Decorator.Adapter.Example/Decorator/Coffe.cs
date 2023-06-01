namespace Serialization.Decorator.Adapter.Example.Decorator;

public abstract class Coffe
{
    public string BaristaName { get; set; }
    public string From { get; set; }
    public abstract decimal GetCost();
}

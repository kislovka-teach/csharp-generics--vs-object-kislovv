namespace Serialization.Decorator.Adapter.Example.Decorator;

public abstract class CoffeDecorator : Coffe
{
    protected Coffe _coffe;

    public CoffeDecorator(Coffe coffe)
    {
        _coffe = coffe;
    }
}
    
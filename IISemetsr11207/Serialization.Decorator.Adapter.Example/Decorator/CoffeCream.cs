namespace Serialization.Decorator.Adapter.Example.Decorator;

public class CoffeCream : CoffeDecorator
{
    public CoffeCream(Coffe coffe) : base(coffe)
    {
    }

    public override decimal GetCost()
    {
        return _coffe.GetCost() + 4;
    }
}
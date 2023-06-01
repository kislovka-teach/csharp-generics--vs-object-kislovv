namespace Serialization.Decorator.Adapter.Example.Decorator;

public class CoffeMilk : CoffeDecorator
{
    public CoffeMilk(Coffe coffe) : base(coffe)
    {
        
    }

    public override decimal GetCost()
    {
        return _coffe.GetCost() + 3;
    }
}
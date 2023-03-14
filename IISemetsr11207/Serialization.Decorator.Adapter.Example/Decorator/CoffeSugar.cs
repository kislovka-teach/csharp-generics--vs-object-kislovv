namespace Serialization.Decorator.Adapter.Example.Decorator;

public class CoffeSugar : CoffeDecorator
{
    public CoffeSugar(Coffe coffe) : base(coffe)
    {
        
    }

    public override decimal GetCost()
    {
        return _coffe.GetCost() + 2;
    }
}
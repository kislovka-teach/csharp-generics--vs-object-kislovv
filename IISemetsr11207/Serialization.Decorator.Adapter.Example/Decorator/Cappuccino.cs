namespace Serialization.Decorator.Adapter.Example.Decorator;

public class Cappuccino : Coffe
{
    public override decimal GetCost()
    {
        return 15;
    }
}

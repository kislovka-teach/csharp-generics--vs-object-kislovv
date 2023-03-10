namespace Serialization.Decorator.Adapter.Example.Decorator
{
    public class Espresso : Coffe
    {
        public override decimal GetCost()
        {
            return 10;
        }
    }
}

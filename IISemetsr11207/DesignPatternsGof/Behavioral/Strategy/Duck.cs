namespace DesignPatternsGof.Behavioral.Strategy;

public abstract class Duck
{
    public IFlyBehavior? FlyBehavior { get; set; }
    public IQuackBehavior? QuackBehavior { get; set; }

    public void Quack()
    {
        QuackBehavior?.Quack();
    }

    public void Fly()
    {
        FlyBehavior?.Fly();
    }
}
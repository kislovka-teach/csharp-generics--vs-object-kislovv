namespace DesignPatternsGof.Behavioral.Strategy;

public class BaseFly : IFlyBehavior
{
    public void Fly()
    {
        Console.WriteLine("Я летаю так себе, как и все здесь");
    }
}
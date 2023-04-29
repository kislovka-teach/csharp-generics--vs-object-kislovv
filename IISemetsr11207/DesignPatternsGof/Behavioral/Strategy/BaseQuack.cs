namespace DesignPatternsGof.Behavioral.Strategy;

public class BaseQuack : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Ну типа кря");
    }
}
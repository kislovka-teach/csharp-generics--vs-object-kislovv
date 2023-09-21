namespace DesignPatternsGof.Creational.AbstractFactory;

public class Step : IMoveable
{
    public void Move()
    {
        Console.WriteLine("Медленно, но грозно шагаю");
    }
}
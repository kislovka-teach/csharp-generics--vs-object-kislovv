namespace DesignPatternsGof.Creational.AbstractFactory;

public class Run : IMoveable
{
    public void Move()
    {
        Console.WriteLine("Бесшумно, словно рысь!");
    }
}
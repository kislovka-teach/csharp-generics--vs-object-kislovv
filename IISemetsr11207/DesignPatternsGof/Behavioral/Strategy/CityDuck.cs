namespace DesignPatternsGof.Behavioral.Strategy;

public class CityDuck : Duck
{
    public override void Quack()
    {
        Console.WriteLine("Я городская утка, давай сюда свой хлебушек - кря!");
    }

    public override void Fly()
    {
        Console.WriteLine("Я улетел за латте! ");
    }
}
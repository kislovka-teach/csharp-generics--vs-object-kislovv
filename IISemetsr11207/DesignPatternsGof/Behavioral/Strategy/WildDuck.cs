namespace DesignPatternsGof.Behavioral.Strategy;

public class WildDuck : Duck
{
    public override void Quack()
    {
        Console.WriteLine("Я дикая утка, ну типа - кря.");
    }

    public override void Fly()
    {
        Console.WriteLine("Хоть я и утка, но летаю как бабочка, а жалю как пчела");
    }
}
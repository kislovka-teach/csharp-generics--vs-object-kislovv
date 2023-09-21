namespace DesignPatternsGof.Creational.AbstractFactory;

public class Arbalet : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Стреляю с арбалета");
    }
}
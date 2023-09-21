namespace DesignPatternsGof.Creational.AbstractFactory;

public class Claymore : Weapon
{
    public override void Hit()
    {
        Console.WriteLine("Махать мечем");
    }
}
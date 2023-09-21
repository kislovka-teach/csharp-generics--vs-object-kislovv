namespace DesignPatternsGof.Creational.AbstractFactory;

public class ElfFactory : IHeroFactory
{
    public Weapon CreateWeapon()
    {
        return new Arbalet();
    }

    public IMoveable ChangeMoveableStrategy()
    {
        return new Run();
    }
}
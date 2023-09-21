namespace DesignPatternsGof.Creational.AbstractFactory;

public class WarriorFactory : IHeroFactory
{
    public Weapon CreateWeapon()
    {
        return new Claymore();
    }

    public IMoveable ChangeMoveableStrategy()
    {
        return new Step();
    }
}
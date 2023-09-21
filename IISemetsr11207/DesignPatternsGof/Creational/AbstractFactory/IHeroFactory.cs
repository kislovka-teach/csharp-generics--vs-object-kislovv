namespace DesignPatternsGof.Creational.AbstractFactory;

public interface IHeroFactory
{
    Weapon CreateWeapon();
    IMoveable ChangeMoveableStrategy();
}
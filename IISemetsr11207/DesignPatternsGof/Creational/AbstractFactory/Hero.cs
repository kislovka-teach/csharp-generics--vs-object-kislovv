namespace DesignPatternsGof.Creational.AbstractFactory;

public class Hero
{
    private Weapon _weapon;
    private IMoveable _moveable;

    public Hero(IHeroFactory heroFactory)
    {
        _weapon = heroFactory.CreateWeapon();
        _moveable = heroFactory.ChangeMoveableStrategy();
    }

    public void Hit()
    {
        _weapon.Hit();
    }

    public void Move()
    {
        _moveable.Move();
    }
}
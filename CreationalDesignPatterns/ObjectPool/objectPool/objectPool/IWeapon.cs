namespace looseCoupling
{
    public interface IWeapon
    {
        int Damage { get; }
        void Use(IEnemy enemy);
    }
}
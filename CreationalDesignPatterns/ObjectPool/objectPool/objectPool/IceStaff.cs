namespace looseCoupling
{
    public class IceStaff : IWeapon
    {
        private readonly int _damage;

        private readonly int _iceDamage;
        public int Damage => _damage;
        public int IceDamage => _iceDamage;

        public IceStaff(int damage, int iceDamage)
        {
            _damage = damage;
            _iceDamage = iceDamage;
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= Damage;
            enemy.Armor -= IceDamage;
        }
    }
}
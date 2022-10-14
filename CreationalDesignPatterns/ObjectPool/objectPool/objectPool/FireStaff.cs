namespace looseCoupling
{
    public class FireStaff : IWeapon
    {
        private readonly int _damage;

        private readonly int _fireDamage;
        public int Damage => _damage;
        public int FireDamage => _fireDamage;

        public FireStaff(int damage, int fireDamage)
        {
            _damage = damage;
            _fireDamage = fireDamage;
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= Damage;
            enemy.Armor -= FireDamage;
        }
    }
}
namespace looseCoupling
{
    public class Sword : IWeapon
    {
        private readonly int _damage;

        private readonly int _armorDamage;
        public int Damage => _damage;
        public int ArmorDamage => _armorDamage;

        public Sword(int damage, int armorDamage)
        {
            _damage = damage;
            _armorDamage = armorDamage;
        }

        public void Use(IEnemy enemy)
        {
            enemy.Health -= Damage;
            enemy.Armor -= ArmorDamage;
        }
    }
}
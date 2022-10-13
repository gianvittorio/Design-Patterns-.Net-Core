using System;

namespace looseCoupling
{
    public class Giant : IEnemy
    {
        private int _health;
        private readonly int _level;

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public int Level => _level;

        public Giant(int health, int level)
        {
            this._health = health;
            this._level = level;
        }
        
        public int OvertimeDamage { get; set; }
        
        public int Armor { get; set; }
        
        public bool Paralyzed { get; set; }
        
        public int ParalyzedFor { get; set; }

        public void Attack(PrimaryPlayer player)
        {
            Console.WriteLine($"Giant attacking {player.Name}");
        }

        public void Defend(PrimaryPlayer player)
        {
            Console.WriteLine($"Giant defending from {player.Name}");
        }
    }
}
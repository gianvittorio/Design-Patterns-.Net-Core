using System;
using System.Collections.Generic;

namespace looseCoupling
{
    public class EnemyFactory
    {
        private int _areaLevel;
        private Stack<Zombie> _zombiesPool = new Stack<Zombie>();
        private Stack<Werewolf> _werewolvesPool = new Stack<Werewolf>();
        private Stack<Giant> _giantsPool = new Stack<Giant>();

        public int AreaLevel
        {
            get => _areaLevel;
            set => _areaLevel = value;
        }

        public EnemyFactory(int areaLevel)
        {
            _areaLevel = areaLevel;
            PreloadZombies();
            PreloadWerewolves();
            PreloadGiants();
        }

        private void PreloadZombies()
        {
            int count;
            int health;
            int armor;
            int level;

            if (_areaLevel < 3)
            {
                count = 15;
            }
            else if (_areaLevel < 10)
            {
                count = 50;
            }
            else
            {
                count = 200;
            }

            (health, level, armor) = GetZombieStatus(_areaLevel);
            while (count-- > 0)
            {
                _zombiesPool.Push(new Zombie(health, level, armor));
            }
        }

        private (int health, int level, int armor) GetZombieStatus(int areaLevel)
        {
            int health;
            int armor;
            int level;
            
            if (areaLevel < 3)
            {
                health = 66;
                level = 2;
                armor = 15;
            }
            else if (areaLevel < 10)
            {
                health = 66;
                level = 5;
                armor = 15;
            }
            else
            {
                health = 100;
                level = 8;
                armor = 15;
            }

            return (health, level, armor);
        }

        private void PreloadWerewolves()
        {
        }

        private void PreloadGiants()
        {
        }

        public void ReclaimZombie(Zombie zombie)
        {
            (int health, int level, int armor) = GetZombieStatus(_areaLevel);
            zombie.Health = health;
            zombie.Armor = armor;

            _zombiesPool.Push(zombie);
        }

        public Werewolf SpawnWerewolf(int areaLevel)
        {
            return new Werewolf(100, (areaLevel < 5) ? (12) : (20));
        }

        public Giant SpawnGiant(int areaLevel)
        {
            return new Giant(100, (areaLevel < 5) ? (14) : (32));
        }

        public Zombie SpawnZombie(int areaLevel)
        {
            if (_zombiesPool.Count > 0)
            {
                return _zombiesPool.Pop();
            }
            
            throw new Exception("Zombies pool depleted.");
        }
    }
}
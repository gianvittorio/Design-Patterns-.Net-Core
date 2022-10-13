namespace looseCoupling
{
    public static class EnemyFactory
    {
        public static Werewolf SpawnWerewolf(int areaLevel)
        {
            return new Werewolf(100, (areaLevel < 5) ? (12) : (20));
        }

        public static Giant SpawnGiant(int areaLevel)
        {
            return new Giant(100, (areaLevel < 5) ? (14) : (32));
        }

        public static Zombie SpawnZombie(int areaLevel)
        {
            if (areaLevel < 3)
            {
                return new Zombie(66, 2, 15);
            }

            if (areaLevel < 10)
            {
                return new Zombie(66, 5, 15);
            }
            
            return new Zombie(100, 8, 15);
        }
    }
}
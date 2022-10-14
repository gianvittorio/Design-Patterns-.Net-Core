using System;
using System.Collections.Generic;

namespace factory
{
    public class GameBoard
    {
        private PrimaryPlayer _player;

        public GameBoard()
        {
            _player = PrimaryPlayer.Instance;
        }

        public void PlayArea(int lvl)
        {
            if (lvl == 1)
            {
                PlayFirstLevel();
            }
        }

        public void PlayFirstLevel()
        {
            const int currLvl = 1;
            List<IEnemy> enemies = new List<IEnemy>();
            for (int i = 0; i < 10; i++)
            {
                enemies.Add(EnemyFactory.SpawnZombie(currLvl));
            }

            for (int i = 0; i < 3; i++)
            {
                enemies.Add(EnemyFactory.SpawnWerewolf(currLvl));
            }

            foreach (var enemy in enemies)
            {
                Console.WriteLine(enemy.GetType());
            }
        }
    }
}
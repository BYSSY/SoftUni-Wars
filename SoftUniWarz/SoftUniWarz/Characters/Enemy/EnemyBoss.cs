namespace SoftUniWarz.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class EnemyBoss : Enemy
    {
        private const string EnemyBossName = "Nakov & Dancho & Judge";
        private const int EnemyBossHealthPoint = 800;
        private const int EnemyBossManaPoints = 500;

        public EnemyBoss(string texturePath)
            : base(EnemyBossName,
                  EnemyBossHealthPoint,
                  EnemyBossManaPoints,
                  texturePath)
        {
        }
    }
}

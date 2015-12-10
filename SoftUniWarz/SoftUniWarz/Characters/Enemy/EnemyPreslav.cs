using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniWarz.Characters
{
    class EnemyPreslav : Enemy
    {
        private const string EnemyPreslavName = "Preslav";
        private const int EnemyPreslavHealthPoints = 500;
        private const int EnemyPreslavManaPoints = 500;

        public EnemyPreslav(string texturePath)
            : base(EnemyPreslavName,
                  EnemyPreslavHealthPoints,
                  EnemyPreslavManaPoints,
                  texturePath)
        {
        }

    }
}
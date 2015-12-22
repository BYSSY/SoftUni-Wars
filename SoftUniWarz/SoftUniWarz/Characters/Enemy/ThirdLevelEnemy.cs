using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniWarz.Characters.Enemy
{
    class ThirdLevelEnemy : Enemy
    {
        private static readonly Vector2 DefaultEnemyPosition = new Vector2(750, 200);
        private const int DefaultFirstEnemyHealth = 500;
        private const int DefaultFirsEnemyMana = 300;
        private const string DefaultFirstEnemyName = "Royal the Hut";
        private const string DefaultFirstEnemyTexturePath = "royal";

        public ThirdLevelEnemy()
           : base(
                 DefaultFirstEnemyName,
                 DefaultFirstEnemyHealth,
                 DefaultFirsEnemyMana,
                 DefaultFirstEnemyTexturePath,
                 DefaultEnemyPosition)
        {
        }
    }
}

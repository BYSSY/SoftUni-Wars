namespace SoftUniWarz.Characters.Enemy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.Xna.Framework;

    public class FinalBoss : Enemy
    {
        private static readonly Vector2 DefaultEnemyPosition = new Vector2(750, 100);
        private const int DefaultFirstEnemyHealth = 500;
        private const int DefaultFirsEnemyMana = 300;
        private const string DefaultFirstEnemyName = "The darth gang";
        private const string DefaultFirstEnemyTexturePath = "boss";

        public FinalBoss()
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

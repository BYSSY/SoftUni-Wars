
namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;
    using System;

    class SimpleEnemyAttack : Attack
    {
        private static readonly int DefaultSimpleEnemyAttackDamage = 65;
        private static readonly int DefaultSimpleEnemyAttacManaCost = 30;
        private static readonly string[] texturePaths = new string[]
        {
            "dumbel", "dna", "wine"
        };
        private static readonly Random rnd = new Random();

        public SimpleEnemyAttack(Vector2 position)
            : base(DefaultSimpleEnemyAttackDamage, DefaultSimpleEnemyAttacManaCost, texturePaths[rnd.Next(0, 3)], position)
        {
        }
    }
}

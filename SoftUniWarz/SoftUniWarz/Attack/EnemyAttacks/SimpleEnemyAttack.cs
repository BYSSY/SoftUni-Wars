
namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;
    using System;

    class SimpleEnemyAttack : Attack
    {
        private const int DefaultSimpleEnemyAttackDamage = 65;
        private const int DefaultSimpleEnemyAttacManaCost = 30;
        private const bool isParalizable = false;
        private static readonly string[] DefaultSimpleEnemyAttackTexturePaths = new string[]
        {
            "dumbel", "dna", "wine"
        };
        private static readonly Random rnd = new Random();

        public SimpleEnemyAttack(Vector2 position)
            : base(
                  DefaultSimpleEnemyAttackDamage,
                  DefaultSimpleEnemyAttacManaCost,
                  isParalizable,
                  DefaultSimpleEnemyAttackTexturePaths[rnd.Next(0, 3)],
                  position)
        {
        }
    }
}

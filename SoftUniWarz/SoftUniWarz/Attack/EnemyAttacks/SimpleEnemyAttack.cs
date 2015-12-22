
namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;
    using System;

    class SimpleEnemyAttack : Attack
    {
<<<<<<< HEAD
        private static readonly int DefaultSimpleEnemyAttackDamage = 65;
        private static readonly int DefaultSimpleEnemyAttacManaCost = 30;
        private static readonly string[] texturePaths = new string[]
=======
        private const int DefaultSimpleEnemyAttackDamage = 65;
        private const int DefaultSimpleEnemyAttacManaCost = 30;
        private const bool isParalizable = false;
        private static readonly string[] DefaultSimpleEnemyAttackTexturePaths = new string[]
>>>>>>> 25289c1335d6cc11632785e3b034143533dd6489
        {
            "dumbel", "dna", "wine"
        };
        private static readonly Random rnd = new Random();

        public SimpleEnemyAttack(Vector2 position)
<<<<<<< HEAD
            : base(DefaultSimpleEnemyAttackDamage, DefaultSimpleEnemyAttacManaCost, texturePaths[rnd.Next(0, 3)], position)
=======
            : base(
                  DefaultSimpleEnemyAttackDamage,
                  DefaultSimpleEnemyAttacManaCost,
                  isParalizable,
                  DefaultSimpleEnemyAttackTexturePaths[rnd.Next(0, 3)],
                  position)
>>>>>>> 25289c1335d6cc11632785e3b034143533dd6489
        {
        }
    }
}

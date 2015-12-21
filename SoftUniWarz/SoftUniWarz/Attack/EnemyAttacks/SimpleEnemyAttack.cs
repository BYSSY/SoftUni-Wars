
namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;
    using System;

    class SimpleEnemyAttack : Attack
    {
        private static readonly int damage = 50;
        private static readonly int manaCost = 10;
        private static readonly bool isParalizable = false;
        private static readonly string[] texturePaths = new string[]
        {
            "dumbel", "dna", "wine"
        };
        private static readonly Random rnd = new Random();

        public SimpleEnemyAttack(Vector2 position)
            : base(damage, manaCost, isParalizable, texturePaths[rnd.Next(0, 3)], position)
        {
        }
    }
}

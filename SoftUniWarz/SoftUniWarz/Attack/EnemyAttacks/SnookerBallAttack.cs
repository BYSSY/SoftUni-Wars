namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;
    using System;

    class SnookerBallAttack : Attack
    {
        private static readonly int DefaultSnookerBallAttackDamage = 80;
        private static readonly int DefaultSnookerBallAttackManaCost = 30;
        private static readonly string[] texturePaths = new string[]
          {
            "ball1", "ball2", "ball3"
          };
        private static readonly Random rnd = new Random();

        public SnookerBallAttack(Vector2 position)
            : base(DefaultSnookerBallAttackDamage, DefaultSnookerBallAttackManaCost, texturePaths[rnd.Next(0, 3)], position)
        {
        }
    }
}

namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;
    using System;

    class SnookerBallAttack : Attack
    {
<<<<<<< HEAD
        private static readonly int DefaultSnookerBallAttackDamage = 50;
        private static readonly int DefaultSnookerBallAttackManaCost = 20;
        private static readonly string[] texturePaths = new string[]
          {
            "ball1", "ball2", "ball3"
          };
        private static readonly Random rnd = new Random();

        public SnookerBallAttack(Vector2 position)
            : base(DefaultSnookerBallAttackDamage, DefaultSnookerBallAttackManaCost, texturePaths[rnd.Next(0, 3)], position)
=======
        private const int DefaultSnookerBallAttackDamage = 50;
        private const int DefaultSnookerBallAttackManaCost = 20;

        private const bool isParalizable = false;
        private const string DefaultSnookerBallAttackTexturePath = "";
        // TODO: Set texture path.

        public SnookerBallAttack(Vector2 position)
            : base(
                  DefaultSnookerBallAttackDamage,
                  DefaultSnookerBallAttackManaCost,
                  isParalizable,
                  DefaultSnookerBallAttackTexturePath,
                  position)
>>>>>>> 25289c1335d6cc11632785e3b034143533dd6489
        {
        }
    }
}

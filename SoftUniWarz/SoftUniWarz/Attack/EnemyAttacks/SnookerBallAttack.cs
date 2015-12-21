namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;

    class SnookerBallAttack : Attack
    {
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
        {
        }
    }
}

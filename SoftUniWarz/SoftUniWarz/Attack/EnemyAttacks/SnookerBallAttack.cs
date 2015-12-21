namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;

    class SnookerBallAttack : Attack
    {
        private static readonly int DefaultSnookerBallAttackDamage = 50;
        private static readonly int DefaultSnookerBallAttackManaCost = 20;

        private static readonly bool isParalizable = false;
        private static readonly string texturePath = "";
        // TODO: Set texture path.

        public SnookerBallAttack(Vector2 position)
            : base(DefaultSnookerBallAttackDamage, DefaultSnookerBallAttackManaCost, isParalizable, texturePath, position)
        {
        }
    }
}

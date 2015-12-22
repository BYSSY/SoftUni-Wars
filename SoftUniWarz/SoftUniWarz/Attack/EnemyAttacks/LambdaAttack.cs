namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;

    class LambdaAttack : Attack
    {
        private static readonly int DefaultLambdaAttackDamage = 120;
        private static readonly int DefaultLambdaAttackManaCost = 60;
        private static readonly string DefaultLambdaAttackTexturePath = "LAMBDA";

        public LambdaAttack(Vector2 position)
            : base(DefaultLambdaAttackDamage, DefaultLambdaAttackManaCost, DefaultLambdaAttackTexturePath, position)
        {
        }
    }
}

namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;

    class LambdaAttack : Attack
    {
        private const int DefaultLambdaAttackDamage = 70;
        private const int DefaultLambdaAttackManaCost = 30;
        private const bool isParalizable = false;
        private const string texturePath = "";
        // TODO: SetTexturePath

        public LambdaAttack(Vector2 position)
            : base(DefaultLambdaAttackDamage, DefaultLambdaAttackManaCost, isParalizable, texturePath, position)
        {
        }
    }
}

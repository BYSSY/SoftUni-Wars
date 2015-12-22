namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;

    class LambdaAttack : Attack
    {
<<<<<<< HEAD
        private static readonly int DefaultLambdaAttackDamage = 70;
        private static readonly int DefaultLambdaAttackManaCost = 30;
        private static readonly string texturePath = "";
        // TODO: SetTexturePath

        public LambdaAttack(Vector2 position)
            : base(DefaultLambdaAttackDamage, DefaultLambdaAttackManaCost, texturePath, position)
=======
        private const int DefaultLambdaAttackDamage = 70;
        private const int DefaultLambdaAttackManaCost = 30;
        private const bool isParalizable = false;
        private const string DefaultLambdaAttackTexturePath = "";
        // TODO: SetTexturePath

        public LambdaAttack(Vector2 position)
            : base(
                  DefaultLambdaAttackDamage,
                  DefaultLambdaAttackManaCost,
                  isParalizable,
                  DefaultLambdaAttackTexturePath,
                  position)
>>>>>>> 25289c1335d6cc11632785e3b034143533dd6489
        {
        }
    }
}

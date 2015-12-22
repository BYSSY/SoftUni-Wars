namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;

    class LambdaAttack : Attack
    {
<<<<<<< HEAD
        private static readonly int DefaultLambdaAttackDamage = 120;
        private static readonly int DefaultLambdaAttackManaCost = 60;
        private static readonly string texturePath = "";
=======
        private static readonly int DefaultLambdaAttackDamage = 70;
        private static readonly int DefaultLambdaAttackManaCost = 30;
        private static readonly string texturePath = "LAMBDA";
>>>>>>> ee8f39fc4011434506df2e43bb477c6a64e26a3d

        public LambdaAttack(Vector2 position)
            : base(DefaultLambdaAttackDamage, DefaultLambdaAttackManaCost, texturePath, position)
        {
        }
    }
}

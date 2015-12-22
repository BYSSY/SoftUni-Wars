namespace SoftUniWarz.Characters.Enemy
{
    using Microsoft.Xna.Framework;

    public class SecondLevelEnemy : Enemy
    {
        private static readonly Vector2 DefaultEnemyPosition = new Vector2(950, 200);
        private const int DefaultFirstEnemyHealth = 500;
        private const int DefaultFirsEnemyMana = 300;
        private const string DefaultFirstEnemyName = "EduBaka";
        private const string DefaultFirstEnemyTexturePath = "edu";


        public SecondLevelEnemy()
           : base(
                 DefaultFirstEnemyName,
                 DefaultFirstEnemyHealth,
                 DefaultFirsEnemyMana,
                 DefaultFirstEnemyTexturePath,
                 DefaultEnemyPosition)
        {
        }
    }
}

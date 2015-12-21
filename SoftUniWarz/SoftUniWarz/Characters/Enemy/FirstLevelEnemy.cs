namespace SoftUniWarz
{
    using Characters.Enemy;
    using Microsoft.Xna.Framework;

    public class FirstLevelEnemy : Enemy
    {
        private static readonly Vector2 DefaultEnemyPosition = new Vector2(700, 0);
        private const int DefaultFirstEnemyHealth = 500;
        private const int DefaultFirsEnemyMana = 300;
        private const string DefaultFirstEnemyName = "Pre-C-3PO";
        private const string DefaultFirstEnemyTexturePath = "Player2";


        public FirstLevelEnemy()
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

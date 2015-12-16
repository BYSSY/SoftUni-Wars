using SoftUniWarz.Characters.Enemy;

namespace SoftUniWarz
{
    public class FirstLevelEnemy : Enemy
    {
        private const int DefaultFirstEnemyHealth = 500;
        private const int DefaultFirsEnemyMana = 300;
        private const string DefaultFirstEnemyName = "Preslav";
        private const string DefaultFirstEnemyTexturePath = "Player2";


        public FirstLevelEnemy()
           : base(
                 DefaultFirstEnemyName,
                 DefaultFirstEnemyHealth,
                 DefaultFirsEnemyMana,
                 DefaultFirstEnemyTexturePath)
        {
        }
    }
}

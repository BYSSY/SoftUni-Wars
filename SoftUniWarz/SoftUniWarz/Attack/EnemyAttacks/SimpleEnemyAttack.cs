
namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;

    class SimpleEnemyAttack : Attack
    {
        private static readonly int damage = 40;
        private static readonly int manaCost = 10;
        private static readonly bool isParalizable = false;
        private static readonly string texturePath = "";
        // TODO: Set texture path.

        public SimpleEnemyAttack(Vector2 position)
            : base(damage, manaCost, isParalizable, texturePath, position)
        {
        }
    }
}

namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;

    public class StreamsAttack : Attack
    {
        // TODO: Delete attack.
        private static readonly int damageTake = 85;
        private static readonly int manaTake = 35;

        private static readonly bool isParalizable = false;
        private static readonly string texturePath = "";
        // TODO: Set texture path.

        public StreamsAttack(Vector2 position)
            : base(damageTake, manaTake, isParalizable, texturePath, position)
        {
        }
    }
}

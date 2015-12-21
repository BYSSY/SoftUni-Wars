
namespace SoftUniWarz.Attack.PlayerAttacks
{
    using Microsoft.Xna.Framework;

    class ResharperAttack : Attack
    {
        private static readonly int damage = 100;
        private static readonly int manaCost = 50;
        private static readonly bool isParalizable = false;
        private static readonly string texturePath = "BinAttack";
        // Set texture path.

        public ResharperAttack(Vector2 position)
            : base(damage, manaCost, isParalizable, texturePath, position)
        {
        }
    }
}

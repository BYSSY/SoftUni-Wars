namespace SoftUniWarz.Attack
{
    using Microsoft.Xna.Framework;

    class TermosThrowAttack : Attack
    {
        private static readonly int damageTake = 80;
        private static readonly int manaTake = 40;
        private static readonly bool isParalizable = false;
        private static readonly string texturePath = "thermus";
        // TODO: Set texture path.

        public TermosThrowAttack(Vector2 position)
            : base(damageTake, manaTake, isParalizable, texturePath, position)
        {
        }
    }
}

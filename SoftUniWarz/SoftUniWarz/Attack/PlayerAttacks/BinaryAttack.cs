namespace SoftUniWarz.Attack.PlayerAttacks
{
    using Microsoft.Xna.Framework;

    class BinaryAttack : Attack
    {
        private static readonly int damageTake = 70;
        private static readonly int beerTake = 25;
        private static readonly bool isParalizable = false;
        private static readonly string path = "";
        // TODO: Set texture path.

        public BinaryAttack( Vector2 position, int width, int height, bool isActive, bool isVisible) 
            : base(damageTake, beerTake, isParalizable, path, position)
        {
        }
    }
}

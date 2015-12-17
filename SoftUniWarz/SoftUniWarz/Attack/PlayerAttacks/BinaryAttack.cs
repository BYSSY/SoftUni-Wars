namespace SoftUniWarz.Attack.PlayerAttacks
{
    using Microsoft.Xna.Framework;

    class BinaryAttack : Attack
    {
        private static readonly int damageTake = 70;
        private static readonly int beerTake = 25;
        private static readonly bool isParalizable = false;
        private static readonly string path = "BinAttack";
        // TODO: Set texture path.

        public BinaryAttack( Vector2 position) 
            : base(damageTake, beerTake, isParalizable, path, position)
        {
        }
    }
}

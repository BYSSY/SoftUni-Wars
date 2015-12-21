namespace SoftUniWarz.Attack.PlayerAttacks
{
    using Microsoft.Xna.Framework;

    class BinaryAttack : Attack
    {
        private static readonly int damage = 70;
        private static readonly int manaCost = 50;
        private static readonly bool isParalizable = false;
        private static readonly string path = "BinAttack";

        public BinaryAttack( Vector2 position) 
            : base(damage, manaCost, isParalizable, path, position)
        {
        }
    }
}

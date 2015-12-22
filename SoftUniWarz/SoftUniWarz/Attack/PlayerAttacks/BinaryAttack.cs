namespace SoftUniWarz.Attack.PlayerAttacks
{
    using Microsoft.Xna.Framework;

    class BinaryAttack : Attack
    {
        private const int DefaultBinaryAttackDamage = 80;
        private const int DefaultBinaryAttackManaCOst = 50;
        private const string path = "BinAttack";

        public BinaryAttack( Vector2 position) 
            : base(DefaultBinaryAttackDamage, DefaultBinaryAttackManaCOst, path, position)
        {
        }
    }
}

namespace SoftUniWarz.Attack.PlayerAttacks
{
    using Microsoft.Xna.Framework;

    class BinaryAttack : Attack
    {
        private const int DefaultBinaryAttackDamage = 70;
        private const int DefaultBinaryAttackManaCOst = 40;
        private const string path = "BinAttack";

        public BinaryAttack( Vector2 position) 
            : base(DefaultBinaryAttackDamage, DefaultBinaryAttackManaCOst, path, position)
        {
        }
    }
}

namespace SoftUniWarz.Attack.PlayerAttacks
{
    using Microsoft.Xna.Framework;

    class BinaryAttack : Attack
    {
        private const int DefaultBinaryAttackDamage = 80;
        private const int DefaultBinaryAttackManaCOst = 50;
<<<<<<< HEAD
        private const string path = "BinAttack";

        public BinaryAttack( Vector2 position) 
            : base(DefaultBinaryAttackDamage, DefaultBinaryAttackManaCOst, path, position)
=======
        private static readonly bool isParalizable = false;
        private const string DefaultBinaryAttackTexturePath = "BinAttack";

        public BinaryAttack( Vector2 position) 
            : base(
                  DefaultBinaryAttackDamage,
                  DefaultBinaryAttackManaCOst,
                  isParalizable,
                  DefaultBinaryAttackTexturePath,
                  position)
>>>>>>> 25289c1335d6cc11632785e3b034143533dd6489
        {
        }
    }
}

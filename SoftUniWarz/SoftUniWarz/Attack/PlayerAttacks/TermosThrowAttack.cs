namespace SoftUniWarz.Attack
{
    using Microsoft.Xna.Framework;

    class TermosThrowAttack : Attack
    {
        private const int DefaultTermosThrowAttackDamage = 80;
        private const int DefaultTermosThrowAttackManaCost = 40;
<<<<<<< HEAD
        private const string texturePath = "thermus";

        public TermosThrowAttack(Vector2 position)
            : base(DefaultTermosThrowAttackDamage, DefaultTermosThrowAttackManaCost, texturePath, position)
=======
        private static readonly bool isParalizable = false;
        private const string DefaultTermosThrowAttackTexturePath = "thermus";

        public TermosThrowAttack(Vector2 position)
            : base(
                  DefaultTermosThrowAttackDamage,
                  DefaultTermosThrowAttackManaCost,
                  isParalizable,
                  DefaultTermosThrowAttackTexturePath,
                  position)
>>>>>>> 25289c1335d6cc11632785e3b034143533dd6489
        {
        }
    }
}

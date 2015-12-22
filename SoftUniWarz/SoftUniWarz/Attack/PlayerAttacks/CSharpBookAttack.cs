namespace SoftUniWarz.Attack.PlayerAttacks
{
    using Microsoft.Xna.Framework;

    class CSharpBookAttack : Attack
    {
        private const int DefaultCSharpBookAttackDamage = 60;
        private const int DefaultCSharpBookAttackManaCost = 30;
<<<<<<< HEAD
        private const string texturePath = "book";

        public CSharpBookAttack(Vector2 position)
            : base(DefaultCSharpBookAttackDamage, DefaultCSharpBookAttackManaCost, texturePath, position)
=======
        private static readonly bool isParalizable = false;
        private const string DefaultCSharpBookAttackTexturePath = "book";

        public CSharpBookAttack(Vector2 position)
            : base(
                  DefaultCSharpBookAttackDamage,
                  DefaultCSharpBookAttackManaCost,
                  isParalizable,
                  DefaultCSharpBookAttackTexturePath,
                  position)
>>>>>>> 25289c1335d6cc11632785e3b034143533dd6489
        {
        }
    }
}

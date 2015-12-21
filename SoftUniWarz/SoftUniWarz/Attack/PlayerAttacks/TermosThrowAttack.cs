namespace SoftUniWarz.Attack
{
    using Microsoft.Xna.Framework;

    class TermosThrowAttack : Attack
    {
        private const int DefaultTermosThrowAttackDamage = 80;
        private const int DefaultTermosThrowAttackManaCost = 40;
        private static readonly bool isParalizable = false;
        private const string DefaultTermosThrowAttackTexturePath = "thermus";

        public TermosThrowAttack(Vector2 position)
            : base(
                  DefaultTermosThrowAttackDamage,
                  DefaultTermosThrowAttackManaCost,
                  isParalizable,
                  DefaultTermosThrowAttackTexturePath,
                  position)
        {
        }
    }
}

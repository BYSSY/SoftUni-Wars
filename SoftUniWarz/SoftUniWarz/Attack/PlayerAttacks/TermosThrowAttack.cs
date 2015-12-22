namespace SoftUniWarz.Attack
{
    using Microsoft.Xna.Framework;

    class TermosThrowAttack : Attack
    {
        private const int DefaultTermosThrowAttackDamage = 90;
        private const int DefaultTermosThrowAttackManaCost = 40;
        private const string texturePath = "thermus";

        public TermosThrowAttack(Vector2 position)
            : base(DefaultTermosThrowAttackDamage, DefaultTermosThrowAttackManaCost, texturePath, position)
        {
        }
    }
}

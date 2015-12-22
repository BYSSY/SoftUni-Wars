namespace SoftUniWarz.Attack.PlayerAttacks
{
    using Microsoft.Xna.Framework;

    class CSharpBookAttack : Attack
    {
        private const int DefaultCSharpBookAttackDamage = 60;
        private const int DefaultCSharpBookAttackManaCost = 30;
        private const string texturePath = "book";

        public CSharpBookAttack(Vector2 position)
            : base(DefaultCSharpBookAttackDamage, DefaultCSharpBookAttackManaCost, texturePath, position)
        {
        }
    }
}

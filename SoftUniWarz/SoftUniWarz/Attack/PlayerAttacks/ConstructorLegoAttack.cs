namespace SoftUniWarz.Attack
{
    using Microsoft.Xna.Framework;

    public class ConstructorLegoAttack : Attack
    {
        private const int DefaultConstructorLegoAttackDamage = 100;
        private const int DefaultConstructorLegoManaCost = 50;
        private const string texturePath = "constructor";

        public ConstructorLegoAttack(Vector2 position)
            : base(DefaultConstructorLegoAttackDamage, DefaultConstructorLegoManaCost, texturePath, position)
        {
        }
    }
}

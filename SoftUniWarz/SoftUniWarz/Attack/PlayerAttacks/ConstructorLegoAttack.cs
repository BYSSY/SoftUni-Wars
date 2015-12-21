namespace SoftUniWarz.Attack
{
    using Microsoft.Xna.Framework;

    public class ConstructorLegoAttack : Attack
    {
        private const int DefaultConstructorLegoAttackDamage = 95;
        private const int DefaultConstructorLegoManaCost = 45;
        private static readonly bool isParalizable = false;
        private const string texturePath = "constructor";

        public ConstructorLegoAttack(Vector2 position)
            : base(DefaultConstructorLegoAttackDamage, DefaultConstructorLegoManaCost, isParalizable, texturePath, position)
        {
        }
    }
}

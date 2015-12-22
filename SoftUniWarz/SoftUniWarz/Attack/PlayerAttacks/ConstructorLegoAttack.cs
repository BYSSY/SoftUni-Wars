namespace SoftUniWarz.Attack
{
    using Microsoft.Xna.Framework;

    public class ConstructorLegoAttack : Attack
    {
        private const int DefaultConstructorLegoAttackDamage = 95;
        private const int DefaultConstructorLegoManaCost = 45;
<<<<<<< HEAD
        private const string texturePath = "constructor";

        public ConstructorLegoAttack(Vector2 position)
            : base(DefaultConstructorLegoAttackDamage, DefaultConstructorLegoManaCost, texturePath, position)
=======
        private static readonly bool isParalizable = false;
        private const string DefaultConstructorLegoAttackTexturePath = "constructor";

        public ConstructorLegoAttack(Vector2 position)
            : base(
                  DefaultConstructorLegoAttackDamage,
                  DefaultConstructorLegoManaCost,
                  isParalizable,
                  DefaultConstructorLegoAttackTexturePath,
                  position)
>>>>>>> 25289c1335d6cc11632785e3b034143533dd6489
        {
        }
    }
}

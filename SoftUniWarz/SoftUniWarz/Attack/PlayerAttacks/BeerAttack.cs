namespace SoftUniWarz.Attack.PlayerAttacks
{
    using Microsoft.Xna.Framework;

    class BeerAttack : Attack
    {
        private const int DefaultBeerAttackDamage = 70;
        private const int DefaultBeerAttackManaCost = 30;
<<<<<<< HEAD
        private const string texturePath = "beer";

        public BeerAttack(Vector2 position)
            : base(DefaultBeerAttackDamage, DefaultBeerAttackManaCost, texturePath, position)
=======
        private static readonly bool isParalizable = false;
        private const string DefaultBeerAttackTexturePath = "beer";

        public BeerAttack(Vector2 position)
            : base(
                  DefaultBeerAttackDamage,
                  DefaultBeerAttackManaCost,
                  isParalizable,
                  DefaultBeerAttackTexturePath,
                  position)
>>>>>>> 25289c1335d6cc11632785e3b034143533dd6489
        {
        }
    }
}

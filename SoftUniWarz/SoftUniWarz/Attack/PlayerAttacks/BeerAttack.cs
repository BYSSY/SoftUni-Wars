namespace SoftUniWarz.Attack.PlayerAttacks
{
    using Microsoft.Xna.Framework;

    class BeerAttack : Attack
    {
        private const int DefaultBeerAttackDamage = 70;
        private const int DefaultBeerAttackManaCost = 30;
        private static readonly bool isParalizable = false;
        private const string texturePath = "beer";

        public BeerAttack(Vector2 position)
            : base(DefaultBeerAttackDamage, DefaultBeerAttackManaCost, isParalizable, texturePath, position)
        {
        }
    }
}

namespace SoftUniWarz.Attack.PlayerAttacks
{
    using Microsoft.Xna.Framework;

    class BeerAttack : Attack
    {
        private static readonly int damageTake = 70;
        private static readonly int manaTake = 30;
        private static readonly bool isParalizable = false;
        private static readonly string texturePath = "beer";

        public BeerAttack(Vector2 position)
            : base(damageTake, manaTake, isParalizable, texturePath, position)
        {
        }
    }
}

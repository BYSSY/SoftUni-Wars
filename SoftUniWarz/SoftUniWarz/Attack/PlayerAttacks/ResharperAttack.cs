namespace SoftUniWarz.Attack.PlayerAttacks
{
    using Microsoft.Xna.Framework;

    class ResharperAttack : Attack
    {
        private const int DefaultResharperAttackDamage = 100;
        private const int DefaultResharperAttackManaCost = 70;
        private const string texturePath = "rshp";

        public ResharperAttack(Vector2 position)
            : base(DefaultResharperAttackDamage, DefaultResharperAttackManaCost, texturePath, position)
        {
        }
    }
}


namespace SoftUniWarz.Attack.PlayerAttacks
{
    using Microsoft.Xna.Framework;

    class ResharperAttack : Attack
    {
        private const int DefaultResharperAttackDamage = 100;
        private const int DefaultResharperAttackManaCost = 50;
        private static readonly bool isParalizable = false;
        private const string DefaultResharperAttackTexturePath = "rshp";

        public ResharperAttack(Vector2 position)
            : base(
                  DefaultResharperAttackDamage,
                  DefaultResharperAttackManaCost,
                  isParalizable,
                  DefaultResharperAttackTexturePath,
                  position)
        {
        }
    }
}

namespace SoftUniWarz.Attack.PlayerAttacks
{
    using Microsoft.Xna.Framework;

    class ResharperAttack : Attack
    {
        private const int DefaultResharperAttackDamage = 100;
        private const int DefaultResharperAttackManaCost = 50;
<<<<<<< HEAD
        private const string texturePath = "rshp";

        public ResharperAttack(Vector2 position)
            : base(DefaultResharperAttackDamage, DefaultResharperAttackManaCost, texturePath, position)
=======
        private static readonly bool isParalizable = false;
        private const string DefaultResharperAttackTexturePath = "rshp";

        public ResharperAttack(Vector2 position)
            : base(
                  DefaultResharperAttackDamage,
                  DefaultResharperAttackManaCost,
                  isParalizable,
                  DefaultResharperAttackTexturePath,
                  position)
>>>>>>> 25289c1335d6cc11632785e3b034143533dd6489
        {
        }
    }
}

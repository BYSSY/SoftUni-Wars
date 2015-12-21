namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;

    class OOPPrincipleAttack : Attack
    {
        private static readonly int DefaultOOPPrincipleAttackAttack = 80;
        private static readonly int DefaultOOPPrincipleAttackAttackManaCost = 40;
        private static readonly bool isParalizable = false;
        private static readonly string texturePath = "";
        // TODO: Set texture path;

        public OOPPrincipleAttack(Vector2 position)
            : base(DefaultOOPPrincipleAttackAttack, DefaultOOPPrincipleAttackAttackManaCost, isParalizable, texturePath, position )
        {
        }
    }
}

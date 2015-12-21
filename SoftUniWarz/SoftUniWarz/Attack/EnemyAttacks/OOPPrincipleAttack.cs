namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;

    class OOPPrincipleAttack : Attack
    {
        private const int DefaultOOPPrincipleAttackAttack = 80;
        private const int DefaultOOPPrincipleAttackAttackManaCost = 40;
        private const bool isParalizable = false;
        private const string texturePath = "";
        // TODO: Set texture path;

        public OOPPrincipleAttack(Vector2 position)
            : base(DefaultOOPPrincipleAttackAttack, DefaultOOPPrincipleAttackAttackManaCost, isParalizable, texturePath, position )
        {
        }
    }
}

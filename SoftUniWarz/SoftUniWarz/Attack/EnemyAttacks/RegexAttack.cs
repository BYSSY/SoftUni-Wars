namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;

    public class RegexAttack : Attack
    {
        private const int DefaultRegexAttackDamage = 60;
        private const int DefaultRegexAttackManaCost = 25;
        private const bool isParalizable = false;
        private const string texturePath = "";
        // TODO: SetTexturePath

        
        public RegexAttack(Vector2 position)
            : base(DefaultRegexAttackDamage, DefaultRegexAttackManaCost, isParalizable, texturePath, position)
        {
        }
    }
}

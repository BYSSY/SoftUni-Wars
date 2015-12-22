namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;

    public class RegexAttack : Attack
    {
        private static readonly int DefaultRegexAttackDamage = 80;
        private static readonly int DefaultRegexAttackManaCost = 40;
        private static readonly string texturePath = "regex";
                
        public RegexAttack(Vector2 position)
            : base(DefaultRegexAttackDamage, DefaultRegexAttackManaCost, texturePath, position)
        {
        }
    }
}

namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;

    public class RegexAttack : Attack
    {
        private static readonly int DefaultRegexAttackDamage = 60;
        private static readonly int DefaultRegexAttackManaCost = 25;
        private static readonly string texturePath = "regex";
        // TODO: SetTexturePath

        
        public RegexAttack(Vector2 position)
            : base(DefaultRegexAttackDamage, DefaultRegexAttackManaCost, texturePath, position)
        {
        }
    }
}

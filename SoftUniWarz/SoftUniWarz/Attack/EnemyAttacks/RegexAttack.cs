namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;

    public class RegexAttack : Attack
    {
<<<<<<< HEAD
        private static readonly int DefaultRegexAttackDamage = 60;
        private static readonly int DefaultRegexAttackManaCost = 25;
        private static readonly string texturePath = "regex";
=======
        private const int DefaultRegexAttackDamage = 60;
        private const int DefaultRegexAttackManaCost = 25;
        private const bool isParalizable = false;
        private const string DefaultRegexAttackTexturePath = "";
>>>>>>> 25289c1335d6cc11632785e3b034143533dd6489
        // TODO: SetTexturePath

        
        public RegexAttack(Vector2 position)
<<<<<<< HEAD
            : base(DefaultRegexAttackDamage, DefaultRegexAttackManaCost, texturePath, position)
=======
            : base(
                  DefaultRegexAttackDamage,
                  DefaultRegexAttackManaCost,
                  isParalizable,
                  DefaultRegexAttackTexturePath,
                  position)
>>>>>>> 25289c1335d6cc11632785e3b034143533dd6489
        {
        }
    }
}

namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;
    using System;

    class OOPPrincipleAttack : Attack
    {
<<<<<<< HEAD
        private static readonly int DefaultOOPPrincipleDamage = 80;
        private static readonly int DefaultOOPPrincipleManaCost = 40;
        private static readonly string[] texturePaths = new string[]
        {
            "abstraction", "oop1", "encapsulation"
        };
        private static readonly Random rnd = new Random();

        public OOPPrincipleAttack(Vector2 position)
            : base(DefaultOOPPrincipleDamage, DefaultOOPPrincipleManaCost, texturePaths[rnd.Next(0, 3)], position )
=======
        private const int DefaultOOPPrincipleAttackAttack = 80;
        private const int DefaultOOPPrincipleAttackAttackManaCost = 40;
        private const bool isParalizable = false;
        private const string DefaultOOPPrincipleAttackAttackTexturePath = "";
        // TODO: Set texture path;

        public OOPPrincipleAttack(Vector2 position)
            : base(
                  DefaultOOPPrincipleAttackAttack,
                  DefaultOOPPrincipleAttackAttackManaCost,
                  isParalizable,
                  DefaultOOPPrincipleAttackAttackTexturePath,
                  position )
>>>>>>> 25289c1335d6cc11632785e3b034143533dd6489
        {
        }
    }
}

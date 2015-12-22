namespace SoftUniWarz.Attack.EnemyAttacks
{
    using Microsoft.Xna.Framework;
    using System;

    class OOPPrincipleAttack : Attack
    {
        private static readonly int DefaultOOPPrincipleDamage = 110;
        private static readonly int DefaultOOPPrincipleManaCost = 50;
        private static readonly string[] texturePaths = new string[]
        {
            "abstraction", "oop1", "encapsulation"
        };
        private static readonly Random rnd = new Random();

        public OOPPrincipleAttack(Vector2 position)
            : base(DefaultOOPPrincipleDamage, DefaultOOPPrincipleManaCost, texturePaths[rnd.Next(0, 3)], position )
        {
        }
    }
}

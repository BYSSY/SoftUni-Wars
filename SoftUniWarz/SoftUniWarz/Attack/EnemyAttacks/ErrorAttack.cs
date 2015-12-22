using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniWarz.Attack.EnemyAttacks
{
    class ErrorAttack : Attack
    {
        private static readonly int DefaultLambdaAttackDamage = 70;
        private static readonly int DefaultLambdaAttackManaCost = 30;
        private static readonly string texturePath = "еррор";

        public ErrorAttack(Vector2 position)
            : base(DefaultLambdaAttackDamage, DefaultLambdaAttackManaCost, texturePath, position)
        {
        }
    }
}

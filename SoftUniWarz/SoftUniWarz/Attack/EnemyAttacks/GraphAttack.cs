using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniWarz.Attack.EnemyAttacks
{
    class GraphAttack : Attack
    {
        private static readonly int DefaultLambdaAttackDamage = 90;
        private static readonly int DefaultLambdaAttackManaCost = 50;
        private static readonly string texturePath = "graph";

        public GraphAttack(Vector2 position)
            : base(DefaultLambdaAttackDamage, DefaultLambdaAttackManaCost, texturePath, position)
        {
        }
    }
}

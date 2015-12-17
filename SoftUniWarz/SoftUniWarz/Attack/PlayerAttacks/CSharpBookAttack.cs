using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace SoftUniWarz.Attack.PlayerAttacks
{
    class CSharpBookAttack : Attack
    {
        private static readonly int damageTake = 60;
        private static readonly int manaTake = 15;
        private static readonly bool isParalizable = false;
        private static readonly string texturePath = "";
        // TODO: Set texture path.

        public CSharpBookAttack(Vector2 position)
            : base(damageTake, manaTake, isParalizable, texturePath, position)
        {
        }
    }
}

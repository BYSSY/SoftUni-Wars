﻿namespace SoftUniWarz.Attack
{
    using Microsoft.Xna.Framework;

    public class ConstructorLegoAttack : Attack
    {
        private static readonly int damageTake = 95;
        private static readonly int manaTake = 45;
        private static readonly bool isParalizable = false;
        private static readonly string texturePath = "constructor";
        // TODO: Set texture path.

        public ConstructorLegoAttack(Vector2 position)
            : base(damageTake, manaTake, isParalizable, texturePath, position)
        {
        }
    }
}

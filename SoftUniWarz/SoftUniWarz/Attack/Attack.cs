﻿namespace SoftUniWarz.Attack
{
    using System;
    using Microsoft.Xna.Framework;
    using Interfaces;

    public abstract class Attack: GameObject, IAttack
    {
        private int damage;
        private int manaCost;
        private const int DefaultAttackTextureWidth = -1;
        private const int DefaultAttackTextureHegth = -1;

        public Attack(
            int damage,
            int manaCost,
            string texturePath,
            Vector2 position)
            
            : base(
                 texturePath,
                 position,
                 DefaultAttackTextureWidth,
                 DefaultAttackTextureHegth)
        {
            this.Damage = damage;
            this.ManaCost = manaCost;
        }

        public int ManaCost
        {
            get
            {
                return manaCost;
            }

            set
            {
                if (value < 0) 
                {
                    throw new InvalidOperationException("Cannot create attack with negative mana cost!");
                }
                manaCost = value;
            }
        }

        public int Damage
        {
            get
            {
                return damage;
            }

            set
            {
                if (value < 0) 
                {
                    throw new ArgumentOutOfRangeException("The attack's damage cannot be negative!");
                }
                damage = value;
            }
        }
    }
}

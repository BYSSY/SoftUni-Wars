namespace SoftUniWarz.Attack
{
    using System;
    using Microsoft.Xna.Framework;
    using SoftUniWarz.Interfaces;

    public abstract class Attack: GameObject, IAttack
    {
        private int damage;
        private int manaCost;
        private const int DefaultAttackTextureWidth = -1;
        private const int DefaultAttackTextureHegth = -1;

        // All the attacks have the same textures sizes.

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
                    throw new ArgumentOutOfRangeException("Cannot steal less than 1 or more than 150 mana!");
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
                    throw new ArgumentOutOfRangeException("Damage cannot be negative!");
                }
                damage = value;
            }
        }
    }
}

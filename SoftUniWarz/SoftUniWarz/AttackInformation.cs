namespace SoftUniWarz
{
    using Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.Xna.Framework;

    public class AttackInformation : IAttackInformation
    {
        private int damage;
        private int manaCost;
        private Vector2 damagePosition;
        private Vector2 manacostPosition;

        public AttackInformation(Vector2 damagePosition, Vector2 manaCostPosition)
        {
            this.DamagePosition = damagePosition;
            this.ManaCostPosition = manaCostPosition;
        }
        public int Damage
        {
            get
            {
                return this.damage;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Cannot create attack with negative damage!");

                }

                this.damage = value;
            }
        }

        public Vector2 DamagePosition
        {
            get
            {
                return this.damagePosition;
            }
            private set
            {

                this.damagePosition = value;
            }
        }

        public int ManaCost
        {
            get
            {
                return this.manaCost;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Cannot create attack with negative mana cost!");

                }

                this.manaCost = value;
            }
        }

        public Vector2 ManaCostPosition
        {
            get
            {
                return this.manacostPosition;
            }
            private set
            {

                this.manacostPosition = value;
            }
        }

        public void AddDamageInformation(int damage)
        {
            this.Damage = damage;
        }

        public void AddManaCostInformation(int manaCost)
        {
            this.ManaCost = manaCost;
        }
    }
}

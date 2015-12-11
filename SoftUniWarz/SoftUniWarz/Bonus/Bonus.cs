using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SoftUniWarz
{
    public abstract class Bonus : GameObject
    {
        private int healthBoost;
        private int manaBoost;

        public Bonus(string texturePath, Vector2 position, int witdh, int height, int healthBoost, int manaBoost)
            : base(texturePath, position, witdh, height)
        {
            this.HealthBoost = healthBoost;
            this.ManaBoost = manaBoost;
        }

        public int HealthBoost
        {
            get { return this.healthBoost; }

            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Bonus cannot be negative!");
                }

                this.healthBoost = value;
            }
        }
        public int ManaBoost

        {
            get { return this.manaBoost; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Mana cannot be negative!");
                }

                this.manaBoost = value;
            }
        }
        
    }
}

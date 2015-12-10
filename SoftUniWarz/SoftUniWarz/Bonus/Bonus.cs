﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SoftUniWarz
{
    public abstract class Bonus : GameObject
    {
<<<<<<< HEAD
        private int healthBoost;
        private int manaBoost;
        public Bonus(int healthBoost,int manaBoost,Texture2D texture, Vector2 position, int witdh, int height, bool isActive, bool isVisible) : base(texture, position, witdh, height, isActive, isVisible)
=======
        public Bonus(string texturePath, Vector2 position, int witdh, int height)
            : base(texturePath, position, witdh, height)
>>>>>>> febc18d86f38e2d09970638aaef45910015a3c72
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

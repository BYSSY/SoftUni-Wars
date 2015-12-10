using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SoftUniWarz
{
    class Beer : Bonus
    {

        
        public Beer(int healthBoost,int manaBoost,Texture2D texture, Vector2 position, int witdh, int height, bool isActive, bool isVisible) : base(texture, position, witdh, height, isActive, isVisible)
        {
            this.HealthBoost = 100;
            this.ManaBoost = 0;
        }

        public int Health {
            get { return this.HealthBoost; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("Health cannot be negative!");
                }
                this.health = value;
            }
        }
    }
}

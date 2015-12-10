using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SoftUniWarz
{
    class Coffee : Bonus
    {
<<<<<<< HEAD
        public Coffee(int healthBoost,int manaBoost,Texture2D texture, Vector2 position, int witdh, int height, bool isActive, bool isVisible) : base(texture, position, witdh, height, isActive, isVisible)
=======
        public Coffee(string texturePath, Vector2 position, int witdh, int height) 
            : base(texturePath, position, witdh, height)
>>>>>>> febc18d86f38e2d09970638aaef45910015a3c72
        {
            this.HealthBoost = 0;
            this.ManaBoost = 100;
            
        }
    }
}

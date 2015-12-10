using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SoftUniWarz
{
    class Coffee : Bonus
    {
        
        private const int healthBoost = 0;
        private const int manaBoost = 100;

        public Coffee(string texturePath, Vector2 position, int witdh, int height) 
            : base(texturePath, position, witdh, height, healthBoost, manaBoost)
        {
        }
    }
}

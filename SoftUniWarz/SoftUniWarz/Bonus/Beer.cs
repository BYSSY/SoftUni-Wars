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
        private const int healthBoost = 150;
        private const int manaBoostt = 0;

        public Beer(string texturePath, Vector2 position, int witdh, int height)
            : base(texturePath, position, witdh, height, healthBoost, manaBoostt)
        {
            
        }

    }
}

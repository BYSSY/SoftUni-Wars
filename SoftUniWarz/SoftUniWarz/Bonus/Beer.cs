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
        public Beer(string texturePath, Vector2 position, int witdh, int height, bool isActive, bool isVisible) 
            : base(texturePath, position, witdh, height)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SoftUniWarz
{
    public class Bonus : GameObject
    {
        public Bonus(string texturePath, Vector2 position, int witdh, int height)
            : base(texturePath, position, witdh, height)
        {
        }
    }
}

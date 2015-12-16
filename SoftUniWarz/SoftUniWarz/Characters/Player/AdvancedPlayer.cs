using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniWarz
{
    class AdvancedPlayer : IntermediatePlayer
    {
        public AdvancedPlayer(string name, int healthPoints, int manaPoints, string playerPath, Vector2 position, int width, int height) 
            : base(name,healthPoints,manaPoints, playerPath,position, width,height)
        {

        }
    }
}

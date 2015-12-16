using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftUniWarz.Interfaces;
using Microsoft.Xna.Framework;

namespace SoftUniWarz
{
    class Player : Character,IAttackable
    {
        public Player(string name, int healthPoints, int manaPoints, string playerPath, Vector2 position, int width , int height) 
            : base(name,healthPoints,manaPoints, playerPath,position, width,height)
        {
        }
    }

    
}

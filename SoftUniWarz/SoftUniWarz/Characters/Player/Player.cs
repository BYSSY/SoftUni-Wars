using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftUniWarz.Interfaces;
using Microsoft.Xna.Framework;

namespace SoftUniWarz
{
    public class Player : Character
    {
        private int healthPoints;
        private const int health = 500;
        public Player(string name, int healthPoints, int manaPoints, string playerPath, Vector2 position, int width , int height) 
            : base(name, health, manaPoints, playerPath,position, width,height)
        {
        }
    }

    
}

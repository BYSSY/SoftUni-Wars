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
        private const int Health = 500;
        private const int Mana = 300;

        public Player(string name, int healthPoints, int manaPoints, string playerPath, Vector2 position, int width , int height) 
            : base(name, Health, Mana, playerPath,position)
        {
        }
    }
}

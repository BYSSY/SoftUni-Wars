using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SoftUniWarz.Attack.PlayerAttacks
{
    class BinaryAttack : Attack
    {
        private static readonly int damageTake = 80;
        private static readonly int manaTake = 0;
        private static readonly int coffeeTake = 0;
        private static readonly int beerTake = 0;
        private static readonly bool isParalizable = false;
        private static readonly string path = "";


        public BinaryAttack( Vector2 position, int width, int height, bool isActive, bool isVisible) 
            : base(damageTake, manaTake, coffeeTake, beerTake, isParalizable, path, position, width, height)
        {
        }
    }
}

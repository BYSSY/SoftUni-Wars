using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SoftUniWarz.Attack
{
    class PlayerAttack : Attack
    {
        private Texture iconTexture;
        private Vector2 position;

        public PlayerAttack(int damageTake, int manaTake, int coffeeTake, int beerTake, bool isParalizable, string texturePath, Vector2 position, int width, int height) 
            : base(damageTake, manaTake, coffeeTake, beerTake, isParalizable, texturePath, position, width, height)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace SoftUniWarz
{
    public abstract class Enemy : Character
    {
        private const int enemyHeight = 300;
        private const int enemyWidth = 150;
        private readonly string path;


        public Enemy(string name, 
            int healthPoints, 
            int manaPoints, 
            Texture2D enemyTexture, 
            Vector2 enemyPosition,
            string path) 

            : base(name,
                  healthPoints,
                  manaPoints,
                  enemyTexture,
                  enemyPosition,
                  enemyWidth,
                  enemyHeight,
                  path)
        {

        }
    }
}

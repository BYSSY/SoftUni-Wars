namespace SoftUniWarz
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.Xna.Framework.Graphics;
    using Microsoft.Xna.Framework;

    public abstract class Enemy : Character
    {
        private const int enemyHeight = 300;
        private const int enemyWidth = 150;
        private readonly string path;
        private static Vector2 enemyPosition = new Vector2(500, 500);


        public Enemy(string name,
            int healthPoints,
            int manaPoints,
            string enemyTexturePath)

            : base(name,
                  healthPoints,
                  manaPoints,
                  enemyTexturePath,
                  enemyPosition,
                  enemyWidth,
                  enemyHeight)
        { }

       
    }
}

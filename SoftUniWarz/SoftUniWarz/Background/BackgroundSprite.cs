using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SoftUniWarz
{
    public class BackgroundSprite:GameObject
    {
        private Texture2D texture;
        private static readonly  Vector2 Position=new Vector2(0,0);
        private int width;
        private int height;
        private bool isVisible;
        private bool isActive;
        public BackgroundSprite(string texturePath, Vector2 position,int width,int height , bool isVisble,bool isActive)
            :base(texturePath, position,width,height)
        {
            
        }


        public  void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, Position, Color.White);
        }
    }
}

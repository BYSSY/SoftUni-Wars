using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SoftUniWarz
{
    public class Background : GameObject
    {
        private Texture2D texture;
        private Vector2 position;

        public Background(Texture2D texture, Vector2 position)
        {
            this.Texture = texture;
            this.Position = position;
        }

        public Texture2D Texture
        {
            get { return this.texture; }
            set { this.texture = value; }
        }
        public Vector2 Position
        {
            get { return this.position; }
            protected set { this.position = value; }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}

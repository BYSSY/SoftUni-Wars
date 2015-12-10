using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SoftUniWarz
{
    public class GameObject
    {
        private Texture2D texture;
        private Vector2 position;
        private int witdh;
        private int height;

        public GameObject(string texturePath, Vector2 position, int witdh, int height)
        {
            //TODO: LOAD textures from texture loader
            //this.Texture = (path);

            this.Position = position;
            this.Witdh = witdh;
            this.Height  = height;
        }

        public Texture2D Texture
        {
            get
            {
                return texture;
            }

            set
            {
                texture = value;
            }
        }

        public Vector2 Position
        {
            get
            {
                return position;
            }

            set
            {
                if (value.X < 0 && value.Y < 0 && value.X + this.Witdh > 1366 && value.Y + this.Height > 768)
                {
                    throw new ArgumentOutOfRangeException("Possition must be valid!");
                }
                position = value;
            }
        }

        public int Witdh
        {
            get
            {
                return witdh;
            }

            set
            {
                if (value>1366)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be more thatn screen size");
                }
                witdh = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value>768)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be more than screen height");
                }
                height = value;
            }
        }

    }
}

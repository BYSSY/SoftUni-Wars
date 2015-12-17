using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SoftUniWarz.Background;
using IDrawable = SoftUniWarz.Interfaces.IDrawable;
using IUpdateable = SoftUniWarz.Interfaces.IUpdateable;

namespace SoftUniWarz
{
    public class GameObject : IDrawable, IUpdateable
    {
        private GUIelements element;
        private int witdh;
        private int height;
        private bool isLoaded;

        public GameObject(string texturePath, Vector2 position, int width, int height)
        {
            //TODO: LOAD textures from texture loader
            //this.Texture = (path);
            element = new GUIelements(texturePath, position, width, height);
            isLoaded = false;
            this.Width = width;
            this.Height  = height;
        }

        public GUIelements Element
        {
            get
            {
                return element;
            }

            set
            {
                element = value;
            }
        }

        public int Width
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

        public bool IsLoaded
        {
            get
            {
                return isLoaded;
            }
        }

        public void LoadContent(ContentManager content)
        {
            this.element.LoadContent(content);
            isLoaded = true;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            this.element.Draw(spriteBatch);
        }

        public virtual void Update()
        {
            this.element.Update();
        }
    }
}

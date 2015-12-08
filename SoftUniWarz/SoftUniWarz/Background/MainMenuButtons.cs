using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace SoftUniWarz.Background
{
    public class MainMenuButtons 
    {
        private Texture2D texture;
        private Vector2 position;
        private Rectangle rectangle;

        Color colour = new Color(255, 255, 255, 255);

        public Vector2 size;

        public MainMenuButtons(Texture2D texture, GraphicsDevice graphics)
        {
            this.texture = texture;


            size = new Vector2(graphics.Viewport.Width / 13, graphics.Viewport.Height / 31);
        }

        private bool down;
        public bool isClicked;

        public void Update(MouseState mouse)
        {

            Rectangle mouseRectangle = new Rectangle(mouse.X, mouse.Y, 1, 1);

            if (mouseRectangle.Intersects(rectangle))
            {
                if (colour.A == 255)
                {
                    down = false;
                }
                if (colour.A == 0)
                {
                    down = true;
                }
                if (down)
                {
                    colour.A += 3;
                }
                else
                {
                    colour.A -= 3;
                }

                if (mouse.LeftButton==ButtonState.Pressed)
                {
                    isClicked = true;
                }
            }
            else if (colour.A < 255)
            {
                colour.A += 3;
                isClicked = false;
            }
        }

        public void SetPosition(Vector2 newPosition)
        {
            position = newPosition;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture,rectangle,colour);
        }

    }
}

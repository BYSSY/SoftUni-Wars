using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using SoftUniWarz.GUIElements;

namespace SoftUniWarz.Buttons
{
    public  class Button : GameObject
    {
        private bool isPressed;
        public event Button.ElementClickedEventHandler ClickEvent;
        //Lambda instead of delegate !
        public delegate void ElementClickedEventHandler(string element);
        
        
        public Button(Buttons texturePath, Vector2 position, int width, int height) 
            : base(texturePath.ToString(), position, width, height)
        {
            isPressed = false;
        }
        
        public override void Update()
        {
            MouseState state = Mouse.GetState();
            if (!isPressed && this.Element.GUIrect.Contains(new Point(state.X, state.Y)) && state.LeftButton == ButtonState.Pressed)
            {
                ClickEvent(this.Element.ElementName);
                isPressed = true;
            }
            else if (state.LeftButton == ButtonState.Released)
            {
                isPressed = false;
            }
        }
    }
}

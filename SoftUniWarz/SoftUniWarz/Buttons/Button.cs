using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using SoftUniWarz.Background;

namespace SoftUniWarz.Buttons
{
    public  class Button : GameObject
    {
        public event Button.ElementClickedEventHandler ClickEvent;
        //Lambda instead of delegate !
        public delegate void ElementClickedEventHandler(string element);
        
        
        public Button(string texturePath, Vector2 position, int width, int height) 
            : base(texturePath, position, width, height)
        {
        }
        
        public override void Update()
        {
            MouseState state = Mouse.GetState();
            if (this.Element.GUIrect.Contains(new Point(state.X, state.Y)) && state.LeftButton == ButtonState.Pressed)
            {
                ClickEvent(this.Element.ElementName);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace SoftUniWarz.Background
{
    public class GUUClickableElement : GUIelements
    {
        public event ElementClickedEventHandler ClickEvent;
        //Lambda instead of delegate !
        public delegate void ElementClickedEventHandler(string element);
        
        public GUUClickableElement(string elementName)
            : base(elementName)
        {
        }

        public override void Update()
        {
            if (this.GUIrect.Contains(new Point(Mouse.GetState().X, Mouse.GetState().Y)) && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                ClickEvent(this.ElementName);
            }
        }
    }
}

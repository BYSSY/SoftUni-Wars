using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SoftUniWarz.Background;

namespace SoftUniWarz.States
{
    class QuitState : State
    {
        private List<GUUClickableElement> clickableElements = new List<GUUClickableElement>(); 
        
        public QuitState()

        {
            clickableElements.Add(new GUUClickableElement("matrix"));
        }

        public override void LoadContent(ContentManager content)
        {
            foreach (var element in clickableElements)
            {
                element.LoadContent(content);
                element.CenterElement(768,1366 );
                element.ClickEvent += OnClick;
            }
        }

        public override void Update()
        {
            foreach (var element in clickableElements)
            {
                element.Update();
            }
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach (var element in clickableElements)
            {
                    element.Draw(spriteBatch);
            }
        }

        private void OnClick(string element)
        {
            Environment.Exit(1);
        }


    }
}

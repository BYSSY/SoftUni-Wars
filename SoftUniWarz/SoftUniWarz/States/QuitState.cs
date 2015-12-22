using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SoftUniWarz.GUIElements;
using SoftUniWarz.Buttons;
using SoftUniWarz.Content;

namespace SoftUniWarz.States
{
    class QuitState : State
    {
        private List<Button> clickableElements = new List<Button>();

        public QuitState(Vector2 screenSize)
            : base(screenSize)
        {
            clickableElements.Add(new Button(Buttons.Buttons.Exit, new Vector2(0, 0), Prefabs.standardBGWidth, Prefabs.standardBGHeight));
        }   

        public override void LoadContent(ContentManager content)
        {
            foreach (var element in clickableElements)
            {
                element.LoadContent(content);
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

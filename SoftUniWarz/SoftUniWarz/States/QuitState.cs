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
        private List<GUIelements> elements = new List<GUIelements>();



        public QuitState()

        {
            elements.Add(new GUIelements("matrix"));
        }

        public override void LoadContent(ContentManager content)
        {
            foreach (var element in elements)
            {
                element.LoadContent(content);
                element.CenterElement(768,1366 );
                element.ClickEvent += OnClick;
            }
        }

        public override void Update()
        {
            foreach (var element in elements)
            {
                element.Update();
            }
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach (var element in elements)
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

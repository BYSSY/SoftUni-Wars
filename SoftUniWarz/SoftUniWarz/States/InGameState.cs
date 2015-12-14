using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SoftUniWarz.Background;

namespace SoftUniWarz.States
{
    class InGameState : State
    {
        //Here should be the main logic and the instatiation of Game1
        List<GUIelements> inGameElements = new List<GUIelements>();

        public InGameState()
        {
            inGameElements.Add(new GUIelements("arenaBG"));

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach (var inGameElement in inGameElements)
            {
                inGameElement.Draw(spriteBatch);
            }
        }

        public override void Update()
        {
            foreach (var inGameElement in inGameElements)
            {
                inGameElement.Update();
            }
        }

        public override void LoadContent(ContentManager content)
        {
            foreach (var guiElements in inGameElements)
            {
                guiElements.LoadContent(content);
                guiElements.CenterElement(768, 1366);
                guiElements.ClickEvent += OnClick;
            }
        }
        public void OnClick(string element)
        {
            if (element == "Play")
            {
                StateManager.ChangeToState(GameState.PickName);
            }
            if (element == "Quit")
            {
                StateManager.ChangeToState(GameState.Quit);
            }
        }
    }
}

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
        List<GUIelements> staticElements = new List<GUIelements>();
        List<GUUClickableElement>  clickableElements = new List<GUUClickableElement>();

        public InGameState()
        {
            staticElements.Add(new GUIelements("arenaBG"));
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach (var inGameElement in staticElements)
            {
                inGameElement.Draw(spriteBatch);
            }
            foreach (var clickableElement in clickableElements)
            {
                clickableElement.Draw(spriteBatch);
            }
        }

        public override void Update()
        {
            foreach (var inGameElement in clickableElements)
            {
                inGameElement.Update();
            }
            foreach (var staticElement in staticElements)
            {
                staticElement.Update();
            }
        }

        public override void LoadContent(ContentManager content)
        {
            foreach (var guiElements in clickableElements)
            {
                guiElements.ClickEvent += OnClick;
            }
            foreach (var staticElement in staticElements)
            {
                staticElement.LoadContent(content);
                staticElement.CenterElement(768, 1366);
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

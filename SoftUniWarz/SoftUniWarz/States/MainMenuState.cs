using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SoftUniWarz.Buttons;
using SoftUniWarz.Content;
using SoftUniWarz.States;

namespace SoftUniWarz.Background
{
    public class MainMenuState : State
    {

        private List<GUIelements> staticElements = new List<GUIelements>();
        private List<Button> clickableElements = new List<Button>(); 

        public MainMenuState(Vector2 screenSize)
            :base(screenSize)
        {
            staticElements.Add(new GUIelements("MainMenuBG", new Vector2(0, 0), Prefabs.standardBGWidth, Prefabs.standardBGHeight));
            clickableElements.Add(new Button("Play", new Vector2(screenSize.X / 2-15, screenSize.Y / 2-30), -1, -1));
            clickableElements.Add(new Button("HighScore", new Vector2(screenSize.X / 2, screenSize.Y / 2 + 70), -1, -1));
            clickableElements.Add(new Button("Quit", new Vector2(screenSize.X / 2, screenSize.Y / 2 + 150), -1, -1));
        }

        public override void LoadContent(ContentManager content)
        {
            foreach (var guiElements in staticElements)
            {
                guiElements.LoadContent(content);
                guiElements.CenterElement(768, 1366);
            }
            foreach (var clickableElement in clickableElements)
            {
                clickableElement.LoadContent(content);
                clickableElement.ClickEvent += OnClick;
            }
        }

        public override void Update()
        {
            foreach (var guiElement in staticElements)
            {
                guiElement.Update();
            }
            foreach (var clickableElement in clickableElements)
            {
                clickableElement.Update();
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach (var guiElements in staticElements)
            {
                guiElements.Draw(spriteBatch);
            }
            foreach (var clickableElement in clickableElements)
            {
                clickableElement.Draw(spriteBatch);
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
            if (element == "HighScore")
            {
                StateManager.ChangeToState(GameState.HighScore);
            }
        }

        
    }
}

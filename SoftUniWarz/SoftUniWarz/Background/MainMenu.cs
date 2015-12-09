using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace SoftUniWarz.Background
{
    public class MainMenu 
    {


        private List<GUIelements> main = new List<GUIelements>();
        private GameState gameState;

        public MainMenu()
        {
            main.Add(new GUIelements("MainMenu"));
            main.Add(new GUIelements("playlogo"));
            main.Add(new GUIelements("quit"));

        }

        public void LoadContent(ContentManager content)
        {
            foreach (var guiElements in main)
            {
                guiElements.LoadContent(content);
                guiElements.CenterElement(768, 1366);
                guiElements.ClickEvent += OnClick;
            }
            main.Find(x => x.ElementName == "playlogo").MoveElement(-200, -150);
            main.Find(y=>y.ElementName=="quit").MoveElement(200,-150);
        }

        public void Update()
        {
            switch (gameState)
            {
                case GameState.mainMenu:
                    foreach (var guiElement in main)
                    {
                        guiElement.Update();
                    }
                    break;
                case GameState.inGame:
                    break;
                    case GameState.quit:
                    break;
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            switch (gameState)
            {
                case GameState.mainMenu:
                    foreach (var guiElements in main)
                    {
                        guiElements.Draw(spriteBatch);
                    }
                    break;
                case GameState.inGame:
                    break;
                case GameState.quit:
                    break;
            }

        }

        public void OnClick(string element)
        {
            if (element == "playlogo")
            {
                gameState = GameState.inGame;
            }
            if (element == "quit")
            {
                gameState=GameState.quit;

            }
        }
    }
}

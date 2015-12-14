using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SoftUniWarz.States;

namespace SoftUniWarz.Background
{
    public class MainMenuState : State
    {

        private List<GUIelements> main = new List<GUIelements>();

        public MainMenuState()
        {
            main.Add(new GUIelements("MainMenuBG"));
            main.Add(new GUIelements("Play"));
            main.Add(new GUIelements("HighScore"));
            main.Add(new GUIelements("Quit"));
        }

        public override void LoadContent(ContentManager content)
        {
            foreach (var guiElements in main)
            {
                guiElements.LoadContent(content);
                guiElements.CenterElement(768, 1366);
                guiElements.ClickEvent += OnClick;
            }
            main.Find(x => x.ElementName == "Play").MoveElement(0, -27);
            main.Find(y => y.ElementName == "Quit").MoveElement(0, 27);
        }

        public override void Update()
        {
            foreach (var guiElement in main)
            {
                guiElement.Update();
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach (var guiElements in main)
            {
                guiElements.Draw(spriteBatch);
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

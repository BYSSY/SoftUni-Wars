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

        private List<GUIelements> staticElements = new List<GUIelements>();
        private List<GUUClickableElement> clickableElements = new List<GUUClickableElement>(); 

        public MainMenuState()
        {
            staticElements.Add(new GUIelements("MainMenuBG"));
            clickableElements.Add(new GUUClickableElement("Play"));
            clickableElements.Add(new GUUClickableElement("HighScore"));
            clickableElements.Add(new GUUClickableElement("Quit"));
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
                clickableElement.CenterElement(768, 1366);
                clickableElement.ClickEvent += OnClick;
            }
            clickableElements.Find(x => x.ElementName == "Play").MoveElement(0, -50);
            clickableElements.Find(z => z.ElementName == "HighScore").MoveElement(0, 25);
            clickableElements.Find(y => y.ElementName == "Quit").MoveElement(0, 100);
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
        }

        
    }
}

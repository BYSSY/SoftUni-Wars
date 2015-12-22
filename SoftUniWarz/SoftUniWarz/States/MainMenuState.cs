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
            clickableElements.Add(new Button(Buttons.Buttons.Play, new Vector2(screenSize.X / 2-150, screenSize.Y / 2-105), -1, -1));
            clickableElements.Add(new Button(Buttons.Buttons.HighScore, new Vector2(screenSize.X / 2-130, screenSize.Y / 2 -5), -1, -1));
            clickableElements.Add(new Button(Buttons.Buttons.Quit, new Vector2(screenSize.X / 2-130, screenSize.Y / 2 +75), -1, -1));
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
            if (element == Buttons.Buttons.Play.ToString())
            {
                StateManager.ChangeToState(GameStates.PickName);
            }
            if (element == Buttons.Buttons.Quit.ToString())
            {
                StateManager.ChangeToState(GameStates.Quit);
            }
            if (element == Buttons.Buttons.HighScore.ToString())
            {
                StateManager.ChangeToState(GameStates.HighScore);
            }
        }

        
    }
}

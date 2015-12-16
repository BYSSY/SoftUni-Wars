using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SoftUniWarz.Background;

namespace SoftUniWarz.States
{
    class LevelOneState : State
    {
        //Here should be the main logic and the instatiation of Game1
        List<GUIelements> staticElements = new List<GUIelements>();
        List<GUUClickableElement>  clickableElements = new List<GUUClickableElement>();
        private Player player;
        private FirstLevelEnemy enemy;


        public LevelOneState()
        {   
            staticElements.Add(new GUIelements("arenaBG"));
            staticElements.Add(new GUIelements("Player1"));
            staticElements.Add(new GUIelements("Player2"));
            clickableElements.Add(new GUUClickableElement("PanicButton2"));
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
            if (player.HealthPoints <= 0)
            {
                StateManager.ChangeToState(GameState.MainMenu);
                //TODO: save highscore
            }
            if (enemy.HealthPoints <= 0)
            {
                StateManager.ChangeToState(GameState.LevelTwoState);
            }

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
                guiElements.LoadContent(content);
                guiElements.ClickEvent += OnClick;
            }
            foreach (var staticElement in staticElements)
            {
                staticElement.LoadContent(content);
            }
            staticElements.Find(x=>x.ElementName=="Player1").MoveElement(0,250);
            staticElements.Find(y=>y.ElementName=="Player2").MoveElement(1150,250);
        }
        public void OnClick(string element)
        { 
            if (element == "PanicButton2")
            {
                
            }
        }
    }
}

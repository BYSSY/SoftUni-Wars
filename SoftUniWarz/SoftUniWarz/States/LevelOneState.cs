using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SoftUniWarz.Attack.PlayerAttacks;
using SoftUniWarz.Background;

namespace SoftUniWarz.States
{
    class LevelOneState : State
    {
        //Here should be the main logic and the instatiation of Game1
        List<GUIelements> staticElements = new List<GUIelements>();
        List<GUUClickableElement>  clickableElements = new List<GUUClickableElement>();
        private ContentManager content;
        private Player player;
        private FirstLevelEnemy enemy;
        public LevelOneState(ContentManager content)
        {
            this.content = content;
            player = new NovicePlayer("Nasko");
            enemy = new FirstLevelEnemy();
            staticElements.Add(new GUIelements("arenaBG"));
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
            foreach (var attack in player.SpellPool)
            {
                if (!attack.IsLoaded)
                {
                    attack.LoadContent(content);
                }
                attack.Draw(spriteBatch);
            }
            player.Draw(spriteBatch);
            enemy.Draw(spriteBatch);
        }

        public override void Update()
        {
           //if (player.HealthPoints <= 0)
           //{
           //    StateManager.ChangeToState(GameState.MainMenu);
           //    //TODO: save highscore
           //}
           //if (enemy.HealthPoints <= 0)
           //{
           //    StateManager.ChangeToState(GameState.LevelTwoState);
           //}

            foreach (var inGameElement in clickableElements)
            {
                inGameElement.Update();
            }
            foreach (var staticElement in staticElements)
            {
                staticElement.Update();
            }
            player.Update();
            
                for (int i = 0; i < player.SpellPool.Count; i++)
                {
                    player.SpellPool[i].Element.MoveElement(player.SpellPool[i].Element.GUIrect.X + 1, player.SpellPool[i].Element.GUIrect.Y);
                    if (player.SpellPool[i].Element.GUIrect.X + player.SpellPool[i].Element.GUIrect.Width > 1200)
                    {
                        player.SpellPool.RemoveAt(i);
                    }
                }
            enemy.Update();
        }

        public override void LoadContent(ContentManager content)
        {
            player.LoadContent(content);
            enemy.LoadContent(content);
            foreach (var guiElements in clickableElements)
            {
                guiElements.LoadContent(content);
                guiElements.ClickEvent += OnClick;
            }
            foreach (var staticElement in staticElements)
            {
                staticElement.LoadContent(content);
            }
           
            player.Element.MoveElement(0, 250);
            enemy.Element.MoveElement(1150, 250);
        }
        public void OnClick(string element)
        { 
            if (element == "PanicButton2")
            {
                player.ProduceAttack(new BeerAttack(player.Position));
            }
        }
    }
}

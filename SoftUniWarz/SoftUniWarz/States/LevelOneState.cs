using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SoftUniWarz.Attack.PlayerAttacks;
using SoftUniWarz.Background;
using Microsoft.Xna.Framework;

namespace SoftUniWarz.States
{
    class LevelOneState : LevelState
    {
        //Here should be the main logic and the instatiation of Game1
        List<GUUClickableElement>  clickableElements = new List<GUUClickableElement>();
        private ContentManager content;

        private Texture2D healthTexture;
        private Rectangle healthRectangle;
        private Vector2 healthPosition;

        private Texture2D healthTextureBG;
        private Rectangle healthRectangleBG;
        public LevelOneState(ContentManager content)
            :base()
        {
            this.content = content;
            base.player = new NovicePlayer("Nasko");

            base.enemy = new FirstLevelEnemy();
            base.staticElements.Add(new GUIelements("arenaBG"));
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
            spriteBatch.Draw(healthTextureBG, healthRectangleBG, Color.White);
            spriteBatch.Draw(healthTexture,healthPosition, healthRectangle, Color.White);
            enemy.Draw(spriteBatch);

            
        }

        public override void Update()
        {
            const int PlayerHealth = 500;
            healthRectangleBG = new Rectangle(50, 20, PlayerHealth, 30);

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
                    player.SpellPool[i].Element.MoveElement(15, player.SpellPool[i].Element.GUIrect.Y);
                    if (player.SpellPool[i].Element.GUIrect.X + player.SpellPool[i].Element.GUIrect.Width > enemy.Element.GUIrect.X)
                    {
                        enemy.ApplyAttack(player.SpellPool[i]);
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

            healthTexture = content.Load<Texture2D>("HealthBar");
            healthPosition = new Vector2(50, 20);
            healthRectangle = new Rectangle(0, 0, this.player.HealthPoints, 30);
            healthTextureBG = content.Load<Texture2D>("HealthBarBackground");
        }
        public void OnClick(string element)
        { 
            if (element == "PanicButton2")
            {
                player.ProduceAttack(new BeerAttack(player.Position));
                healthRectangle.Width -= 10;
            }

        }

    }
}

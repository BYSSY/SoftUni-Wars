﻿using System;
using System.Collections.Generic;
using System.Threading;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SoftUniWarz.Attack.PlayerAttacks;
using SoftUniWarz.GUIElements;
using SoftUniWarz.Characters.Enemy;
using SoftUniWarz.Buttons;
using SoftUniWarz.Attack;
using SoftUniWarz.Attack.EnemyAttacks;

namespace SoftUniWarz.States
{
    public abstract class LevelState : State
    {
        // HealthBar Player1
        private Texture2D healthTextureBG;
        private Rectangle playerHealthRectangleBG;

        // ManaBar Player1
        private Texture2D manaTextureBG;
        protected Rectangle playerManaRectangleBG;

        // HealthBar Player2
        private Rectangle enemyHealthRectangleBG;

        // ManaBar Player2
        private Rectangle enemyManaRectangleBG;

        // Mana and Health text
        private SpriteFont spriteFont;

        // Name text
        private SpriteFont nameFont;

        protected bool isPlayerMove;
        protected bool playerHasHit;

        protected List<GUIelement> staticElements;
        protected List<Button> buttons;
        protected Player player;
        protected Enemy enemy;
        protected ContentManager content;


        public LevelState(Vector2 screenSize)
            : base(screenSize)
        {
            staticElements = new List<GUIelement>();
            buttons = new List<Button>();
            isPlayerMove = true;
            playerHasHit = false;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            //Drawing background and all the static sprites
            foreach (var element in staticElements)
            {
                element.Draw(spriteBatch);
            }
            //Drawing all the buttons 
            foreach (var button in buttons)
            {
                button.Draw(spriteBatch);
            }
            player.Draw(spriteBatch);
            enemy.Draw(spriteBatch);
            foreach (var attack in player.SpellPool)
            {
                if (!attack.IsLoaded)
                {
                    attack.LoadContent(content);
                }
                attack.Draw(spriteBatch);
            }
            foreach (var attack in enemy.SpellPool)
            {
                if (!attack.IsLoaded)
                {
                    attack.LoadContent(content);
                }
                attack.Draw(spriteBatch);
            }

            player.Draw(spriteBatch);
            // Drawing the player's bars
            spriteBatch.Draw(healthTextureBG, playerHealthRectangleBG, Color.White);
            spriteBatch.Draw(manaTextureBG, playerManaRectangleBG, Color.White);

            // Drawing enemy's bars
            spriteBatch.Draw(healthTextureBG, enemyHealthRectangleBG, Color.White);
            spriteBatch.Draw(manaTextureBG, enemyManaRectangleBG, Color.White);

            // Player's and enemy's name. 
            spriteBatch.DrawString(spriteFont, this.player.Name, new Vector2(180, 20), Color.White);
            spriteBatch.DrawString(spriteFont, this.enemy.Name, new Vector2(1050, 20), Color.White);
            //spriteBatch.DrawString(spriteFont, this.enemy.Name, new Vector2(1050, 20), Color.White, 0f, new Vector2(0, 0), 1, SpriteEffects.None, 1);


            // Player and enemy health and mana indicators.
            spriteBatch.DrawString(spriteFont, "" + this.player.HealthPoints + "/" + this.player.InitialHealth, new Vector2(290, 52), Color.Black);
            spriteBatch.DrawString(spriteFont, "" + this.player.ManaPoints + "/" + this.player.InitialMana, new Vector2(290, 82), Color.Black);

            spriteBatch.DrawString(spriteFont, "" + this.enemy.HealthPoints + "/" + this.enemy.InitialHealth, new Vector2(1000, 52), Color.Black);
            spriteBatch.DrawString(spriteFont, "" + this.enemy.ManaPoints + "/" + this.enemy.InitialMana, new Vector2(1000, 82), Color.Black);

        }

        public override void Update()
        {
            if (player.HealthPoints <= 0)
            {
                HighScore score = new HighScore();
                score.Write(this.player.Name, StateManager.score);
                StateManager.ChangeToState(GameStates.MainMenuState);
                return;
            }
            //EnemyMove
            if (playerHasHit && !isPlayerMove)
            {
                Thread.Sleep(2000);
                Vector2 positionForMagic = new Vector2(enemy.Element.Position.X + enemy.Element.GUIrect.Width / 2,
                enemy.Element.Position.Y + enemy.Element.GUIrect.Height / 2);
                SimpleEnemyAttack attack = new SimpleEnemyAttack(positionForMagic);
                if (enemy.ManaPoints < attack.ManaCost)
                {
                    enemy.ManaPoints += attack.ManaCost + 10;
                }
                else
                {
                    enemy.ProduceAttack(attack);
                }
                playerHasHit = false;
            }
            foreach (var inGameElement in buttons)
            {
                inGameElement.Update();
            }
            foreach (var staticElement in staticElements)
            {
                staticElement.Update();
            }
            for (int i = 0; i < player.SpellPool.Count; i++)
            {
                player.SpellPool[i].Element.MoveElement(15, 0);
                if (player.SpellPool[i].Element.GUIrect.X + player.SpellPool[i].Element.GUIrect.Width > 1000)
                {
                    enemy.ApplyAttack(player.SpellPool[i]);
                    player.SpellPool.RemoveAt(i);
                    playerHasHit = true;
                }
            }

            for (int i = 0; i < enemy.SpellPool.Count; i++)
            {
                enemy.SpellPool[i].Element.MoveElement(-15, 0);
                if (enemy.SpellPool[i].Element.GUIrect.X + enemy.SpellPool[i].Element.GUIrect.Width < 450)
                {
                    player.ApplyAttack(enemy.SpellPool[i]);
                    enemy.SpellPool.RemoveAt(i);
                    isPlayerMove = true;
                }
            }

            enemy.Update();
            player.Update();
        }

        public override void LoadContent(ContentManager content)
        {

            player.LoadContent(content);
            enemy.LoadContent(content);

            // Player bars
            playerHealthRectangleBG = new Rectangle(180, 50, this.player.InitialHealth - 200, 30);
            playerManaRectangleBG = new Rectangle(180, 80, this.player.InitialMana, 30);

            // Enemy bars
            enemyHealthRectangleBG = new Rectangle(875, 50, this.enemy.InitialHealth - 200, 30);
            enemyManaRectangleBG = new Rectangle(875, 80, this.enemy.InitialMana, 30);

            foreach (var staticElement in staticElements)
            {
                staticElement.LoadContent(content);
            }

            // Setting  mana and health bars' textures.
            healthTextureBG = content.Load<Texture2D>("HealthBar");
            manaTextureBG = content.Load<Texture2D>("ManaBar");
            spriteFont = content.Load<SpriteFont>("MyFont");
        }
    }
}

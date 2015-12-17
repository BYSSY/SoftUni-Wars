using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SoftUniWarz.Attack.PlayerAttacks;
using SoftUniWarz.Background;
using SoftUniWarz.Characters.Enemy;
using SoftUniWarz.Buttons;
using SoftUniWarz.Attack;

namespace SoftUniWarz.States
{
    public abstract class LevelState : State
    {
        protected List<GUIelements> staticElements;
        protected List<Button> buttons;
        protected Player player;
        protected Enemy enemy;
        protected ContentManager content;

        // HealthBar Player1
        private Texture2D playerHealthTexture;
        private Rectangle playerHealthRectangle;
        private Vector2 playerHealthPosition;

        private Texture2D playerHealthTextureBG;
        private Rectangle playerHealthRectangleBG;

        // ManaBar Player1
        private Texture2D playerManaTexture;
        private Rectangle playerManaRectangle;
        private Vector2 playerManaPosition;

        private Texture2D playerManaTextureBG;
        private Rectangle playerManaRectangleBG;

        // HealthBar Player2
        private Texture2D enemyHealthTexture;
        private Rectangle enemyHealthRectangle;
        private Vector2 enemyHealthPosition;

        private Texture2D enemyHealthTextureBG;
        private Rectangle enemyHealthRectangleBG;

        // ManaBar Player2

        private Texture2D enemyManaTexture;
        private Rectangle enemyManaRectangle;
        private Vector2 enemyManaPosition;

        private Texture2D enemyManaTextureBG;
        private Rectangle enemyManaRectangleBG;

        public LevelState(Vector2 screenSize)
            : base(screenSize)
        {
            staticElements = new List<GUIelements>();
            buttons = new List<Button>();
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

            player.Draw(spriteBatch);
            //Drawing the player's bars
            spriteBatch.Draw(playerHealthTextureBG, playerHealthRectangleBG, Color.White);
            spriteBatch.Draw(playerHealthTexture, playerHealthPosition, playerHealthRectangle, Color.White);
            spriteBatch.Draw(playerManaTextureBG, playerManaRectangleBG, Color.White);
            spriteBatch.Draw(playerManaTexture, playerManaPosition, playerManaRectangle, Color.White);
        }

        public override void Update()
        {
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
                if (player.SpellPool[i].Element.GUIrect.X + player.SpellPool[i].Element.GUIrect.Width > enemy.Element.GUIrect.X)
                {
                    enemy.ApplyAttack(player.SpellPool[i]);
                    player.SpellPool.RemoveAt(i);
                }
            }
            enemy.Update();
            player.Update();

            //Player bars backgrounds
            playerHealthRectangleBG = new Rectangle(200, 20, (int)(this.player.HealthPoints * 0.75), 30);
            playerManaRectangleBG = new Rectangle(200, 80, (int)(this.player.HealthPoints * 0.75), 30);
        }

        public override void LoadContent(ContentManager content)
        {
            player.LoadContent(content);
            enemy.LoadContent(content);
            foreach (var guiElements in buttons)
            {
                guiElements.LoadContent(content);
                guiElements.ClickEvent += OnClick;

            }
            foreach (var staticElement in staticElements)
            {
                staticElement.LoadContent(content);
            }

            // Setting player's mana and health bars: textures, position and rectangles.
            playerHealthTexture = content.Load<Texture2D>("HealthBar");
            playerHealthPosition = new Vector2(200, 20);
            playerHealthRectangle = new Rectangle(0, 0, (int)((this.player.HealthPoints) * 0.75), 30);
            playerHealthTextureBG = content.Load<Texture2D>("HealthBarBackground");

            playerManaTexture = content.Load<Texture2D>("ManaBar");
            playerManaPosition = new Vector2(200, 80);
            playerManaRectangle = new Rectangle(0, 0, (int)((this.player.HealthPoints) * 0.75), 30);
            playerManaTextureBG = content.Load<Texture2D>("ManaBarBackground");



        }

        public void OnClick(string element)
        {
            if (element == "PanicButton2")
            {
                BeerAttack beerAttack = new BeerAttack(player.Element.Position);
                player.ProduceAttack(beerAttack);
                ConstructorLegoAttack constructorAttack = new ConstructorLegoAttack(player.Element.Position);
                playerHealthRectangle.Width -= (int)(beerAttack.Damage * 0.75);
                playerManaRectangle.Width -= (int)(beerAttack.ManaCost * 0.75);
            }

        }
    }
}

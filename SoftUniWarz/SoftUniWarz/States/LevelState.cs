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
using SoftUniWarz.Attack.EnemyAttacks;

namespace SoftUniWarz.States
{
    public abstract class LevelState : State
    {
        private readonly int HealthAndManaBarWidth;

        // HealthBar Player1
        private Texture2D healthTexture;
        private Rectangle playerHealthRectangle;
        private Vector2 playerHealthPosition;

        private Texture2D healthTextureBG;
        private Rectangle playerHealthRectangleBG;

        // ManaBar Player1
        private Texture2D manaTexture;
        private Rectangle playerManaRectangle;
        private Vector2 playerManaPosition;

        private Texture2D manaTextureBG;
        private Rectangle playerManaRectangleBG;

        // HealthBar Player2
        private Rectangle enemyHealthRectangle;
        private Vector2 enemyHealthPosition;

        private Rectangle enemyHealthRectangleBG;

        // ManaBar Player2

        private Rectangle enemyManaRectangle;
        private Vector2 enemyManaPosition;

        private Rectangle enemyManaRectangleBG;

        private bool isPlayerMove;
        private bool playerHasHit;

        protected List<GUIelements> staticElements;
        protected List<Button> buttons;
        protected Player player;
        protected Enemy enemy;
        protected ContentManager content;
        

        public LevelState(Vector2 screenSize)
            : base(screenSize)
        {
            staticElements = new List<GUIelements>();
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
            spriteBatch.Draw(healthTexture, playerHealthPosition, playerHealthRectangle, Color.White);
            spriteBatch.Draw(manaTextureBG, playerManaRectangleBG, Color.White);
            spriteBatch.Draw(manaTexture, playerManaPosition, playerManaRectangle, Color.White);

            // Drawing enemy's bars
            spriteBatch.Draw(healthTextureBG, enemyHealthRectangleBG, Color.White);
            spriteBatch.Draw(healthTexture, enemyHealthPosition, enemyHealthRectangle, Color.White);
            spriteBatch.Draw(manaTextureBG, enemyManaRectangleBG, Color.White);
            spriteBatch.Draw(manaTexture, enemyManaPosition, enemyManaRectangle, Color.White);



        }

        public override void Update()
        {
            //EnemyMove
            if (playerHasHit && !isPlayerMove)
            {
                Vector2 positionForMagic = new Vector2(enemy.Element.Position.X + enemy.Element.GUIrect.Width / 2,
               enemy.Element.Position.Y + enemy.Element.GUIrect.Height / 2);
                enemy.ProduceAttack(new BinaryAttack(positionForMagic));
                isPlayerMove = true;
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
                    playerHasHit = true;
                    enemy.ApplyAttack(player.SpellPool[i]);
                    player.SpellPool.RemoveAt(i);
                }
            }
            for (int i = 0; i < enemy.SpellPool.Count; i++)
            {
                enemy.SpellPool[i].Element.MoveElement(-15, 0);
                if (enemy.SpellPool[i].Element.GUIrect.X + enemy.SpellPool[i].Element.GUIrect.Width < 400)
                {
                    playerHasHit = false;
                    player.ApplyAttack(enemy.SpellPool[i]);
                    enemy.SpellPool.RemoveAt(i);
                }
            }
            enemy.Update();
            player.Update();

            //Player bars backgrounds
            playerHealthRectangleBG = new Rectangle(170, 50, this.player.InitialHealth -200, 30);
            playerManaRectangleBG = new Rectangle(170, 80, this.player.InitialMana, 30);

            //
            enemyHealthRectangleBG = new Rectangle(890, 50, this.enemy.InitialHealth-200, 30);
            enemyManaRectangleBG = new Rectangle(890, 80, this.enemy.InitialMana, 30);
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
            healthTexture = content.Load<Texture2D>("HealthBar");
            playerHealthPosition = new Vector2(170, 50);
            playerHealthRectangle = new Rectangle(0, 0, this.player.HealthPoints * 3 / 5, 30);
            healthTextureBG = content.Load<Texture2D>("HealthBarBackground");

            manaTexture = content.Load<Texture2D>("ManaBar");
            playerManaPosition = new Vector2(170, 80);
            playerManaRectangle = new Rectangle(0, 0, this.player.ManaPoints, 30);
            manaTextureBG = content.Load<Texture2D>("ManaBarBackground");

            // Setting enemy's mana and health bar - position and rectangle.
            enemyHealthPosition = new Vector2(890, 50);
            enemyHealthRectangle = new Rectangle(0, 0, this.enemy.HealthPoints * 3 / 5, 30);

            enemyManaPosition = new Vector2(890, 80);
            enemyManaRectangle = new Rectangle(0, 0, this.enemy.ManaPoints, 30);

        }

        public void OnClick(string element)
        {
            if (isPlayerMove)
            {
                Vector2 positionForMagic = new Vector2(player.Element.Position.X + player.Element.GUIrect.Width / 2,
               player.Element.Position.Y + player.Element.GUIrect.Height / 2);
                if (element == "BinaryBtn")
                {
                    BinaryAttack binaryAttack = new BinaryAttack(positionForMagic);
                    player.ProduceAttack(binaryAttack);
                    enemyHealthRectangle.Width = this.enemy.HealthPoints*3/5;
                    playerManaRectangle.Width = this.player.ManaPoints;
                }
                if (element == "BookBtn")
                {
                    SimpleEnemyAttack attack = new SimpleEnemyAttack(positionForMagic);
                    player.ProduceAttack(attack);
                    playerHealthRectangle.Width -= attack.Damage * 3 / 5;
                    playerManaRectangle.Width = this.player.ManaPoints;
                }
                isPlayerMove = false;
            }

        }
    }
}

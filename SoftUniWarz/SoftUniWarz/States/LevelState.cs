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

namespace SoftUniWarz.States
{
    public abstract class LevelState : State
    {
        protected List<GUIelements> staticElements;
        protected List<Button> buttons;
        protected Player player;
        protected Enemy enemy;
        protected ContentManager content;

        private Texture2D healthTexture;
        private Rectangle healthRectangle;
        private Vector2 healthPosition;

        private Texture2D healthTextureBG;
        private Rectangle healthRectangleBG;

        public LevelState(Vector2 screenSize)
            :base(screenSize)
        {
            staticElements = new List<GUIelements>();
            buttons  =new List<Button>();
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
            spriteBatch.Draw(healthTextureBG, healthRectangleBG, Color.White);
            spriteBatch.Draw(healthTexture, healthPosition, healthRectangle, Color.White);
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
            const int PlayerHealth = 500;
            healthRectangleBG = new Rectangle(50, 20, PlayerHealth, 30);

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
            healthTexture = content.Load<Texture2D>("HealthBar");
            healthPosition = new Vector2(50, 20);
            healthRectangle = new Rectangle(0, 0, this.player.HealthPoints, 30);
            healthTextureBG = content.Load<Texture2D>("HealthBarBackground");
        }
        public void OnClick(string element)
        {
            if (element == "PanicButton2")
            {
                player.ProduceAttack(new BeerAttack(player.Element.Position));
                healthRectangle.Width -= 10;
            }

        }
    }
}

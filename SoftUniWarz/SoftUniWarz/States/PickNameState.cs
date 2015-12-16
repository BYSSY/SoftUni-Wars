using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SoftUniWarz.Background;

namespace SoftUniWarz.States
{
    class PickNameState : State
    {

        private List<GUIelements> staticElements = new List<GUIelements>();
        private List<GUUClickableElement> clickableElements = new List<GUUClickableElement>();

        private Keys[] lastPressedKeys = new Keys[5];
        private string name = string.Empty;
        private SpriteFont spriteFont;


        public Keys[] KeysPressed
        {
            get { return this.KeysPressed; }
            set { this.KeysPressed = value; }
        }

        public PickNameState()
        {
            staticElements.Add(new GUIelements("NamePickBG"));
            clickableElements.Add(new GUUClickableElement("done"));
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach (var element in staticElements)
            {
                element.Draw(spriteBatch);
            }
            foreach (var clickableElement in clickableElements)
            {
                clickableElement.Draw(spriteBatch);
            }

            spriteBatch.DrawString(spriteFont, name, new Vector2(635, 480), Color.Black);
        }

        public override void Update()
        {
            foreach (var element in staticElements)
            {
                element.Update();
            }
            foreach (var clickableElement in clickableElements)
            {
                clickableElement.Update();
            }
            GetKeys();
        }


        public override void LoadContent(ContentManager content)
        {
            spriteFont = content.Load<SpriteFont>("MyFont");

            foreach (var element in staticElements)
            {
                element.LoadContent(content);
                element.CenterElement(768, 1366);
            }
            foreach (var clickableElement in clickableElements)
            {
                clickableElement.LoadContent(content);
                clickableElement.CenterElement(768, 1366);
                clickableElement.ClickEvent += OnClick;
            }
            clickableElements.Find(x => x.ElementName == "done").MoveElement(0, 200);
        }

        public void OnClick(string element)
        {
            if (element == "done")
            {
                StateManager.ChangeToState(GameState.LevelOneState);
            }
        }

        public void GetKeys()
        {
            KeyboardState keyboard = Keyboard.GetState();
            Keys[] pressedKeys = keyboard.GetPressedKeys();
            foreach (var key in lastPressedKeys)
            {
                if (!pressedKeys.Contains(key))
                {
                    OnKeyUp(key);
                }
            }
            foreach (var key in pressedKeys)
            {
                if (!lastPressedKeys.Contains(key))
                {
                    OnKeyDown(key);

                }
            }
            lastPressedKeys = pressedKeys;
        }

        public void OnKeyUp(Keys key)
        {

        }

        public void OnKeyDown(Keys key)
        {
            if (key == Keys.Back && name.Length > 0)
            {
                name = name.Remove(name.Length - 1);
            }

            else
            {
                name += key.ToString();
            }
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SoftUniWarz.GUIElements;
using SoftUniWarz.Buttons;
using SoftUniWarz.Content;

namespace SoftUniWarz.States
{
    class PickNameState : State
    {

        private List<GUIelement> staticElements = new List<GUIelement>();
        private List<Button> clickableElements = new List<Button>();

        private Keys[] lastPressedKeys = new Keys[5];
        private string name = string.Empty;
        private SpriteFont spriteFont;


        public Keys[] KeysPressed
        {
            get { return this.KeysPressed; }
            set { this.KeysPressed = value; }
        }

        public PickNameState(Vector2 screenSize)
            :base(screenSize)
        {
            staticElements.Add(new GUIelement("NamePickBG", new Vector2(0,0), Prefabs.standardBGWidth, Prefabs.standardBGHeight));
            clickableElements.Add(new Button(Buttons.Buttons.Done, new Vector2(553,563), -1, -1));
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
                clickableElement.ClickEvent += OnClick;
            }
            
        }

        public void OnClick(string element)
        {
            if (element == Buttons.Buttons.Done.ToString())
            {
                StateManager.PlayerName = name;
                StateManager.ChangeToState(GameStates.LevelOneState);
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

            else if (key == Keys.LeftAlt||key==Keys.RightAlt||key==Keys.RightControl||key==Keys.LeftControl||key==Keys.LeftShift||key==Keys.RightShift||key==Keys.LeftWindows||key==Keys.RightWindows||key==Keys.CapsLock||key==Keys.Tab)
            {
                name += "";
            }
            else if (key==Keys.Space)
            {
                name += " ";
            }
            else if (key == Keys.Enter)
            {
                StateManager.PlayerName = name;
                StateManager.ChangeToState(GameStates.LevelOneState);
            }

            else
            {
                name += key.ToString();

            }
        }

    }
}

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

        private  List<GUIelements> pickName = new List<GUIelements>();
        private  Keys[] lastPressedKeys = new Keys[5];
        private string name = string.Empty;
        private SpriteFont spriteFont;


        public Keys[] KeysPressed
        {
            get { return this.KeysPressed; }
            set { this.KeysPressed = value; }
        }

        public PickNameState()
        {
            pickName.Add(new GUIelements("name"));
            pickName.Add(new GUIelements("done"));
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            foreach (var element in pickName)
            {
                    element.Draw(spriteBatch);
            }
        }

        public override void Update()
        {
            foreach (var element in pickName)
            {
                element.Update();
            }
            GetKeys();
        }


        public override void LoadContent(ContentManager content)
        {

            foreach (var element in pickName)
            {
                element.LoadContent(content);
                element.CenterElement(768,1366);
                element.ClickEvent += OnClick;
            }
            pickName.Find(x=>x.ElementName=="done").MoveElement(0,60);
        }

        public void OnClick(string element)
        {
            if (element =="done")
            {
                StateManager.ChangeToState(GameState.InGame);
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
            foreach (var key in pressedKeys    )
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
            if (key==Keys.Back&&name.Length>0)
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

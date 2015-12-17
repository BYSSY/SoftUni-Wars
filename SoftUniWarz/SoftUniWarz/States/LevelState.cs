using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
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
            
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override void LoadContent(ContentManager content)
        {
            throw new NotImplementedException();
        }
    }
}

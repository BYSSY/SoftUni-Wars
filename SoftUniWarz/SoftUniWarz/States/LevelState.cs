using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
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
        public LevelState()
        {
            staticElements = new List<GUIelements>();
            buttons  =new List<Button>();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
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

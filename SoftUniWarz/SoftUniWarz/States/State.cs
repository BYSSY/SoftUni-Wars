using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using SoftUniWarz.Interfaces;
using IDrawable = SoftUniWarz.Interfaces.IDrawable;
using IUpdateable = SoftUniWarz.Interfaces.IUpdateable;

namespace SoftUniWarz.States
{
    public abstract class State : IDrawable, IUpdateable, IContentLoadable
    {
        public abstract void Draw(SpriteBatch spriteBatch);
        public abstract void Update();
        public abstract void LoadContent(ContentManager content);
    }
}


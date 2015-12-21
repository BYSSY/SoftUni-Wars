namespace SoftUniWarz.Characters.Enemy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.Xna.Framework;
    using Content;

    public abstract class Enemy : Character
    {
        public Enemy(string name, int healthPoints, int manaPoints, string texturePath, Vector2 position)
            : base(name, healthPoints, manaPoints, texturePath, position)
        {
        }
    }
}

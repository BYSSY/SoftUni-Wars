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
        private static readonly Vector2 DefaultEnemyPosition = new Vector2(700, 0);

        public Enemy(
        string name,
        int healthPoints,
        int manaPoints,
        string texturePath)

        : base(
            name,
            healthPoints,
            manaPoints,
            texturePath,
            DefaultEnemyPosition)
        {
        }

    }
}

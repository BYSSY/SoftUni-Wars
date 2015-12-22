namespace SoftUniWarz.Characters.Enemy
{
    using Microsoft.Xna.Framework;

    public abstract class Enemy : Character
    {
        public Enemy(string name, int healthPoints, int manaPoints, string texturePath, Vector2 position)
            : base(name, healthPoints, manaPoints, texturePath, position)
        {
        }
    }
}

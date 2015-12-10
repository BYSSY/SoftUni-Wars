using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace SoftUniWarz
{
    public abstract class Enemy : Character
    {
        private const int enemyHeight = 300;
        private const int enemyWidth = 150;
        private readonly string path;


        public Enemy(string name,
            int healthPoints,
            int manaPoints,
            string enemyTexturePath,
            Vector2 enemyPosition)

            : base(name,
                  healthPoints,
                  manaPoints,
                  enemyTexturePath,
                  enemyPosition,
                  enemyWidth,
                  enemyHeight)
        { }
        // Тези характеристики може да ги определим и при Players, както и интерфейса за магийки IProjectile(IMagic) and so on..
        // Можем да отделим проверките при сетърите в отделен клас (e.g. Validations) и да ги преизползваме.
        // Относно двата метода: ProduceToAttack и RespondToAttack са предложение за логиката на играта за атакуване и т.н. 
      

       
    }
}

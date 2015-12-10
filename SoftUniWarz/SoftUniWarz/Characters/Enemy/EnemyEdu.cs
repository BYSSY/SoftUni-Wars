namespace SoftUniWarz.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class EnemyEdu : Enemy
    {
        private const string EnemyEduName = "Edu";
        private const int EnemyEduHealthPoints = 600;
        private const int EnemyEduManaPoints = 500;

        public EnemyEdu(string texturePath)
            : base(EnemyEduName,
                  EnemyEduHealthPoints,
                  EnemyEduManaPoints,
                  texturePath)
        {
        }
    }
}

namespace SoftUniWarz.Characters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class EnemyRoYal : Enemy
    {
        private const string EnemyRoYalName = "RoYal";
        private const int EnemyRoYalHealthPoint = 700;
        private const int EnemyRoyalManaPoints = 500;

        public EnemyRoYal(string texturePath)
            : base(EnemyRoYalName,
                  EnemyRoYalHealthPoint,
                  EnemyRoyalManaPoints,
                  texturePath)
        {
        }

    }
}
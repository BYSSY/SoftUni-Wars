namespace SoftUniWarz.Characters.Enemy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class FinalBoss : Enemy
    {
        private const int DefaultFinalBossHealth = 800;
        private const int DefaultFinalBossMana = 500;
        private const string DefaultFinalBossName = "TriHeadedMonster";
        private const string DefaultFinalBossTexturePath = @"\..\..\TriHeadedMonster";

        public FinalBoss()
            : base(
                  DefaultFinalBossName,
                  DefaultFinalBossHealth,
                  DefaultFinalBossMana,
                  DefaultFinalBossTexturePath)
        {
        }
    }
}

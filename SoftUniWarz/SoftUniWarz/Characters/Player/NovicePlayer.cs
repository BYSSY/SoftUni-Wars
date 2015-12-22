namespace SoftUniWarz
{
    using Microsoft.Xna.Framework;
    using System.Collections.Generic;

    class NovicePlayer : Player
    {
        private const int healthPoints = 500;
        private const int manaPoints = 500;
        private const string playerPath = "Player1";

        //FIX 
        //private const string name = "dsa";

        private static readonly Vector2 position = new Vector2(60, 0);
        private const int width = -1;
        private const int height = -1;
        private IList<Bonus> inventory;

        public NovicePlayer(string name)
            : base(name, healthPoints, manaPoints, playerPath, position, width, height)
        {
            this.inventory = new List<Bonus>();
        }

        public IEnumerable<Bonus> Inventory { get { return this.inventory; } }

        public void AddBonusToInventory(Bonus bonus)
        {
            Validation.ValidateData.CheckIsNull(bonus, nameof(bonus));
            this.inventory.Add(bonus);
        }
    }
}

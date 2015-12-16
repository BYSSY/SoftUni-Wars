﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniWarz
{
    class NovicePlayer : Character
    {
        private const int healthPoints = 500;
        private const int manaPoints = 500;
        private const string playerPath = null;
        private const Vector2 position = new Vector2(250, 250);
        private const int width = 100;
        private const int height = 150;
        private IList<Bonus> inventory;

        public NovicePlayer(string name)
            : base(name, healthPoints, manaPoints, playerPath, position, width, height)
        {

        }

        public IEnumerable<Bonus> Inventory { get { return this.inventory; } }

        public void AddBonusToInventory(Bonus bonus)
        {
            Validation.ValidateData.CheckIsNull(bonus, nameof(bonus));
            this.inventory.Add(bonus);
        }
    }
}

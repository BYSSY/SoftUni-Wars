using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SoftUniWarz
{
    class Coffee : Bonus
    {
        private const int DefaultCoffeeBonusHealth = 0;
        private const int DefaultCoffeeBonusMana = 100;
        private const string DefaultCoffeeTexturePath = @"\..\..\Coffee";
        private const int DefaultCoffeeWidth = 100;
        private const int DefaultCoffeeHeigth = 100;
        private static readonly Vector2 DefaultCoffeePosition = new Vector2(1100, 100);

        public Coffee() 
            : base(DefaultCoffeeTexturePath,
                  DefaultCoffeePosition,
                  DefaultCoffeeWidth,
                  DefaultCoffeeHeigth,
                  DefaultCoffeeBonusHealth,
                  DefaultCoffeeBonusMana)
        {
        }
    }
}

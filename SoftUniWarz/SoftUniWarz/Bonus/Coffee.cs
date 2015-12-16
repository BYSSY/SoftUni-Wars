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
        private const int healthBoost = 0;
        private const int manaBoost = 100;
        private const string DefaultCoffeeTexturePath = @"\..\..\Coffee";
        private const int DefaultCoffeeWitdh = 100;
        private const int DefaultCofeeHeigth = 100;
        private static readonly Vector2 DefaultCoffeeePosition = new Vector2(150, 100); 


        public Coffee() 
            : base(DefaultCoffeeTexturePath,
                  DefaultCoffeeePosition,
                  DefaultCoffeeWitdh,
                  DefaultCofeeHeigth,
                  healthBoost,
                  manaBoost)
        {
        }
    }
}

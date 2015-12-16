using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SoftUniWarz
{
    class Beer : Bonus
    {
        private const int DefaultBeerBonusHealth = 150;
        private const int DefaultBeerBonusMana = 0;
        private const string DefaultBeerTexturePath = @"\..\..\Beer";
        private const int DefaultBeerWidth = 100;
        private const int DefaultBeerHeigth = 100;
        private static readonly Vector2 DefaultBeerPosition = new Vector2(1000, 100);



        public Beer()
            : base(DefaultBeerTexturePath,
                  DefaultBeerPosition,
                  DefaultBeerWidth,
                  DefaultBeerHeigth,
                  DefaultBeerBonusHealth,
                  DefaultBeerBonusMana)
        {
            
        }

    }
}

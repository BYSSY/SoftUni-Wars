using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace SoftUniWarz.Attack
{
    public class StreamsAttack : Attack
    {
        //TODO: FIX stats of attack
        private static readonly int damageTake = 70;
        private static readonly int manaTake = 5;
        private static readonly int coffeeTake = 0;
        private static readonly int beerTake = 0;
        private static readonly bool isParalizable = false;
        private static readonly string texturePath = "";
        //TODO: fix sizes of images
        private static readonly int width;
        private static readonly int height;

        public StreamsAttack(Vector2 position)
            : base(damageTake, manaTake, coffeeTake, beerTake, isParalizable, texturePath, position, width, height)
        {
        }
    }
}

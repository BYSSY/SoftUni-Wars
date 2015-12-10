using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace SoftUniWarz.Attack
{
    class SimpleEnemyAttack : Attack
    {
        private static readonly int damageTake = 70;
        private static readonly int manaTake = 5;
        private static readonly int coffeeTake = 0;
        private static readonly int beerTake = 0;
        private static readonly int sandwichTake = 0;
        private static readonly bool isParalizable = false; 

        public SimpleEnemyAttack()
            : base(damageTake, manaTake, coffeeTake, beerTake, sandwichTake, isParalizable)
        {
        }
    }
}

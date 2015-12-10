using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SoftUniWarz.Interfaces;

namespace SoftUniWarz
{
    class Player : Character,IAttackable
    {
        public Player(string name, int healthPoints, int manaPoints) : base(name, healthPoints, manaPoints)
        {
        }
    }

    
}
